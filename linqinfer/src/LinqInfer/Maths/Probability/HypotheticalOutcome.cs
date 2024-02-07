﻿using System;

namespace LinqInfer.Maths.Probability
{
    class HypotheticalOutcome<T> : IHypotheticalOutcome<T>
    {
        public HypotheticalOutcome(T outcome, Fraction prior, string name = null)
        {
            Outcome = outcome;
            Name = outcome.ToString();
            PriorProbability = prior;
            PosteriorProbability = prior;
        }

        public event Action<Fraction> Updated;

        public T Outcome { get; }

        public string Name { get; }

        public Fraction PriorProbability { get; }

        public Fraction PosteriorProbability { get; private set; }

        public Fraction Calculate(Fraction likelihoodGivenHypo, Fraction likelihood)
        {
            return Fraction.Divide(Fraction.Multiply(PosteriorProbability, likelihoodGivenHypo, true), likelihood, true);
        }

        public IHypotheticalOutcome<T> Update(Fraction likelihoodGivenHypo, Fraction likelihood)
        {
            PosteriorProbability = Calculate(likelihoodGivenHypo, likelihood);

            Updated?.Invoke(PosteriorProbability);

            return this;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Outcome.GetHashCode() * 7 * PosteriorProbability.GetHashCode();
        }

        public bool Equals(IHypotheticalOutcome<T> other)
        {
            if (other == null) return false;

            if (ReferenceEquals(this, other)) return true;

            return other.PosteriorProbability == PosteriorProbability && Outcome.Equals(other.Outcome);
        }
    }
}