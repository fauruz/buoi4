﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class HinhTron
    {
        private ToaDo _tam;
        private double _banKinh;
        public double BanKinh {  get { return _banKinh; } set { _banKinh = value; } }
        public ToaDo Tam {  get { return _tam; } set { _tam = value; } }
        public HinhTron()
        {
            Tam = new ToaDo();
            BanKinh = 0;
        }
        public HinhTron(ToaDo tam,double bankinh)
        {
            _tam = tam;
            _banKinh = bankinh;
        }
        public double tinhChuVi()
        {

        }
    }
}
