﻿using System.Linq;
using LinqInfer.Maths;
using NUnit.Framework;

namespace LinqInfer.UnitTests.Maths
{
    public class BitVectorTests
    {
        [Test]
        public void HorizontalMultiply_WhenGivenMultiColMatrix_ThenActiveRowsReturned()
        {
            var v1 = new BitVector(true, false, true);
            var m1 = new Matrix(new[] { new[] { 91d, 12 }, new[] { 23.3d, 8 }, new[] { 10.8d, 6 } });

            var x = v1.HorizontalMultiply(m1);

            Assert.That(x.Size, Is.EqualTo(2));
            Assert.That(x[0], Is.EqualTo(91d + 10.8d));
            Assert.That(x[1], Is.EqualTo(12d + 6d));
        }

        [Test]
        public void WhenConstructedWithASingleValueSmallArray_CreatesAValidInstance()
        {
            var vect = new BitVector(new[] { false, true, false });

            Assert.That(vect.Size, Is.EqualTo(3));
            Assert.False(vect.ValueAt(0));
            Assert.True(vect.ValueAt(1));
            Assert.False(vect.ValueAt(2));
        }

        [Test]
        public void WhenConstructedWithIndexes_CreatesAValidInstance()
        {
            var indexes = new[] { 1, 5, 9 };
            var vect = new BitVector(indexes, 12);

            Assert.That(vect.Size, Is.EqualTo(12));

            for (int i = 0; i < 12; i++)
            {
                if (indexes.Contains(i))
                {
                    Assert.That(vect.ValueAt(i), Is.True);
                }
                else
                {
                    Assert.That(vect.ValueAt(i), Is.False);
                }
            }
        }

        [Test]
        public void WhenConstructedWithAMultiValueSmallArray_CreatesAValidInstance()
        {
            var vect = new BitVector(new[] { false, true, false, true, false });

            Assert.That(vect.Size, Is.EqualTo(5));
            Assert.False(vect.ValueAt(0));
            Assert.True(vect.ValueAt(1));
            Assert.False(vect.ValueAt(2));
            Assert.True(vect.ValueAt(3));
            Assert.False(vect.ValueAt(4));

            Assert.That(vect[0], Is.EqualTo(0));
            Assert.That(vect[1], Is.EqualTo(1));
            Assert.That(vect[2], Is.EqualTo(0));
            Assert.That(vect[3], Is.EqualTo(1));
            Assert.That(vect[4], Is.EqualTo(0));
        }

        [Test]
        public void WhenConstructedWithAMultiValueLargerArray_CreatesAValidInstance()
        {
            var values = new[] { false, true, false, true, false, true, true, false, true, true, false };
            var vect = new BitVector(values);

            Assert.That(vect.Size, Is.EqualTo(values.Length));

            int i = 0;

            foreach(var val in values)
            {
                Assert.That(vect.ValueAt(i++), Is.EqualTo(val));
            }
        }

        [Test]
        public void WhenMultipliedByAMatrix_ReturnsTheExpectedVector()
        {
            var matrix = new Matrix(Enumerable.Range(1, 3).Select(n => new double[] { n + 1, n - 1 }));
            var vect = new BitVector(new[] { true, false });

            // | 2, 0 |   | 1, 0 |
            // | 3, 1 | X
            // | 4, 2 |

            var result = matrix * vect;

            Assert.That(result.Size, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(9));
            Assert.That(result[1], Is.EqualTo(0));
        }

        [Test]
        public void ToBase64_WhenConvertedAndDeconverted_CreatesAnEqualInstance()
        {
            var values = Enumerable.Range(1, 20).Select(n => n % 3 == 0).ToArray();
            var vect = new BitVector(values);
            
            var data = vect.ToBase64();

            var vect2 = BitVector.FromBase64(data);

            Assert.That(vect2.Size, Is.EqualTo(values.Length));
            Assert.That(vect.Equals(vect2));
        }

        [Test]
        public void ToByteArray_WhenConvertedAndDeconverted_CreatesAnEqualInstance()
        {
            var values = Enumerable.Range(1, 20).Select(n => n % 3 == 0).ToArray();
            var vect = new BitVector(values);

            var data = vect.ToByteArray();

            var vect2 = BitVector.FromByteArray(data);

            Assert.That(vect2.Size, Is.EqualTo(values.Length));
            Assert.That(vect.Equals(vect2));
        }

        [Test]
        public void Multiply_TwoBitVectors_ReturnsExpectedResult()
        {
            var vect1 = new BitVector(true, true, false, true, false, false, false, true, true);
            var vect2 = new BitVector(false, true, false, true, false, true, false, false, true);

            var result = vect1.MultiplyBy(vect2) as BitVector;

            Assert.That(result, Is.Not.Null);
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));
            Assert.That(result[2], Is.EqualTo(0));
            Assert.That(result[3], Is.EqualTo(1));
            Assert.That(result[4], Is.EqualTo(0));
            Assert.That(result[5], Is.EqualTo(0));
            Assert.That(result[6], Is.EqualTo(0));
            Assert.That(result[7], Is.EqualTo(0));
            Assert.That(result[8], Is.EqualTo(1));
        }

        [Test]
        public void Equals_TwoStrucurallyEquivVectors_ReturnsTrue()
        {
            var values = Enumerable.Range(1, 20).Select(n => n % 3 == 0);
            var vect1 = new BitVector(values.ToArray());
            var vect2 = new BitVector(values.ToArray());

            var result = vect1.Equals(vect2);

            Assert.That(result, Is.True);
        }
    }
}
