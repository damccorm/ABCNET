using System;
using NETMouse.Extensions;

namespace NETMouse.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class Arr
    {
        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static T[] Gen<T>(int count, Func<int, T> selector, int firstIndex = 0)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (selector == null)
                throw new ArgumentNullException("selector");
            
            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = selector(i + firstIndex);

            return source;
        }

        /// <summary>
        /// ������ ������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static T[] Gen<T>(int count, T first, Func<T, T> next)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (next == null)
                throw new ArgumentNullException("next");
            
            T[] source = new T[count];
            source[0] = first;
            for (int i = 1; i < source.Length; i++)
                source[i] = next(source[i - 1]);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static int[] Rand(int count, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            int[] source = new int[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = RandomHelper.Random.Next(low, high);

            return source;
        }

        /// <summary>
        /// ������ ������ ��������� ����� ���� Real.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static double[] Rand(int count, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (low > high)
                throw new ArgumentException("low");

            double[] source = new double[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = RandomHelper.Random.Next((float)low, (float)high);

            return source;
        }

        /// <summary>
        /// ������ ������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static T[] Fill<T>(int count, T value)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            T[] source = new T[count];
            for (int i = 0; i < source.Length; i++)
                source[i] = value;

            return source;
        }

        /// <summary>
        /// ������ ������ �������� ���� Integer.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static bool[] ReadBoolean(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            bool[] array = new bool[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Char.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static char[] ReadChar(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Real.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static double[] ReadReal(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            double[] array = new double[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� Integer.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static int[] ReadInteger(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            int[] array = new int[count];
            int i = 0;
            while (i < count)
                try
                {
                    array[i] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorHelper.Message);
                }

            return array;
        }

        /// <summary>
        /// ������ ������ �������� ���� String.
        /// </summary>
        /// <param name="count">���������� ���������.</param>
        /// <param name="prompt">����������� � �����.</param>
        /// <returns>������.</returns>
        public static string[] ReadString(int count, string prompt = EmptyStringHelper.Empty)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");

            string[] array = new string[count];
            for (int i = 0; i < count; i++)
                array[i] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i));
            return array;
        }
    }
}