// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="RegimeEspecial.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014-2023 Grupo OpenAC.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.NFSe.Nacional.Common.Types;

/// <summary>
/// Tipos de Regimes Especiais de Tributação.
/// </summary>
public enum RegimeEspecial
{
    /// <summary>
    /// 0 - Nenhum
    /// </summary>
    [DFeEnum("0")]
    Nenhum,

    /// <summary>
    /// 1 - Ato Cooperado (Cooperativa)
    /// </summary>
    [DFeEnum("1")]
    Cooperativa,

    /// <summary>
    /// 2 - Estimativa
    /// </summary>
    [DFeEnum("2")]
    Estimativa,

    /// <summary>
    /// 3 - Microempresa Municipal
    /// </summary>
    [DFeEnum("3")]
    MicroempresaMunicipal,

    /// <summary>
    /// 4 - Notário ou Registrador
    /// </summary>
    [DFeEnum("4")]
    NotarioRegistrador,

    /// <summary>
    /// 5 - Profissional Autônomo
    /// </summary>
    [DFeEnum("5")]
    ProfissionalAutonomo,

    /// <summary>
    /// 6 - Sociedade de Profissionais
    /// </summary>
    [DFeEnum("6")]
    SociedadeProfissionais,
}