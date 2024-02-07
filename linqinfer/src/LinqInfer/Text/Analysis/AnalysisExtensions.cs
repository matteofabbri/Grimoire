﻿using LinqInfer.Data.Serialisation;
using LinqInfer.Learning;
using LinqInfer.Learning.Features;
using LinqInfer.Text.VectorExtraction;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LinqInfer.Text.Analysis
{
    public static class AnalysisExtensions
    {
        public static async Task<IImportableExportableSemanticSet> ExtractKeyTermsAsync(this ICorpus corpus, CancellationToken cancellationToken = default)
        {
            var builder = new SemanticSetBuilder();

            await builder.AddAsync(corpus, cancellationToken);

            return builder.Build();
        }

        public static ContinuousBagOfWords CreateContinuousBagOfWords(this ICorpus corpus, ISemanticSet targetVocabulary, ISemanticSet widerVocabulary = null)
        {
            var cbow = new ContinuousBagOfWords(corpus.Words, targetVocabulary, widerVocabulary);

            return cbow;
        }

        public static async Task<IAsyncTrainingSet<WordData, string>> CreateAggregatedTrainingSetAsync(this AsyncContinuousBagOfWords cbow, CancellationToken cancellationToken, int contextPadding = 2)
        {
            var aggreg = new CBowAggregator(cbow.GetNGramSource(contextPadding), cbow.WiderVocabulary);

            var trainingSet = await aggreg.GetTrainingSetAync(cancellationToken);

            return trainingSet;
        }

        public static async Task<VectorExtractionResult> ExtractVectorsAsync<T>(
            this IAsyncTrainingSet<T, string> trainingSet,
            CancellationToken cancellationToken, int vectorSize) where T : class
        {
            return await new WordVectorExtractor().ExtractVectorsAsync(trainingSet, cancellationToken, vectorSize);
        }

        public static async Task<VectorExtractionResult> ExtractVectorsAsync<T>(
            this IAsyncTrainingSet<T, string> trainingSet,
            CancellationToken cancellationToken, PortableDataDocument existingModelData) where T : class
        {
            return await new WordVectorExtractor().ExtractVectorsAsync(trainingSet, cancellationToken, existingModelData);
        }

        public static ITrainingSet<SyntacticContext, string> AsNGramTrainingSet(this ContinuousBagOfWords cbow, int contextPadding = 2)
        {
            var data = cbow.GetNGrams(contextPadding).AsQueryable();

            var encoder = new OneHotTextEncoding<SyntacticContext>(cbow.WiderVocabulary, t => t.ContextualWords.Select(w => w.Text.ToLowerInvariant()).ToArray());

            var pipeline = data.CreatePipeline(encoder);

            return pipeline.AsTrainingSet(t => t.TargetWord.Text);
        }

        public static AsyncContinuousBagOfWords CreateAsyncContinuousBagOfWords(this ICorpus corpus, ISemanticSet targetVocabulary, ISemanticSet widerVocabulary = null)
        {
            return new AsyncContinuousBagOfWords(corpus, targetVocabulary, widerVocabulary);
        }

        public static IAsyncTrainingSet<SyntacticContext, string> AsNGramAsyncTrainingSet(this AsyncContinuousBagOfWords cbow, int contextPadding = 2)
        {
            var encoder = new OneHotTextEncoding<SyntacticContext>(cbow.WiderVocabulary, t => t.ContextualWords.Select(w => w.NormalForm()).ToArray());

            var pipeline = new AsyncFeatureProcessingPipeline<SyntacticContext>(cbow.GetNGramSource(contextPadding), encoder);

            var omf = new OutputMapperFactory<BiGram, string>();

            var mapper = omf.Create(cbow.TargetVocabulary.Words);

            return pipeline.AsTrainingSet(t => t.TargetWord.NormalForm(), mapper);
        }

        public static IAsyncTrainingSet<BiGram, string> AsBiGramAsyncTrainingSet(this AsyncContinuousBagOfWords cbow, int contextPadding = 2)
        {
            var encoder = new OneHotTextEncoding<BiGram>(cbow.WiderVocabulary, t => new []{ t.Input });

            var pipeline = new AsyncFeatureProcessingPipeline<BiGram>(cbow.GetBiGramSource(contextPadding), encoder);

            var omf = new OutputMapperFactory<BiGram, string>();

            var mapper = omf.Create(cbow.TargetVocabulary.Words);

            return pipeline.AsTrainingSet(t => t.Output, mapper);
        }
    }
}