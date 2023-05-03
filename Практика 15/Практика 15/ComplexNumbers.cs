using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_15
{
    class ComplexNumbers
    {
        //Действительная часть
        public double Vaild { get; set; }
        //Мнимая часть
        public double Imaginary { get; set; }

        //public ComplexNumbers(double vaild, double imaginary)
        //{
        //    this.vaild = vaild;
        //    this.imaginary = imaginary;
        //}
        public ComplexNumbers(double vaild, double imaginary)
        {
            Vaild = vaild;
            Imaginary = imaginary;
        }
        //Сумма
        public string Sum(ComplexNumbers a)
        {
            double vaild = Vaild + a.Vaild ;
            double imaginary = Imaginary + a.Imaginary;
            return $"{vaild} + {imaginary}i";
        }
        //Разность
        public string Dif(ComplexNumbers a)
        {
            double vaild = Vaild - a.Vaild;
            double imaginary = Imaginary - a.Imaginary;
            return $"{vaild} - {imaginary}i";
        }
        //Умножение
        public string Mul(ComplexNumbers a)
        {
            double vaild = Vaild * a.Vaild;
            double imaginary = Imaginary * a.Imaginary;
            return $"{vaild} * {imaginary}i";
        }

    }
}
