﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="InformacoesLocacao.cs" company="OpenAC .Net">
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
using OpenAC.Net.DFe.Core.Serializer;
using OpenAC.Net.NFSe.Nacional.Common.Types;

namespace OpenAC.Net.NFSe.Nacional.Common.Model;

/// <summary>
/// Representa as informações de locação.
/// </summary>
public sealed class InformacoesLocacao
{
    /// <summary>
    /// Categoria da locação.
    /// </summary>
    [DFeElement(TipoCampo.Enum, "categ", Ocorrencia = Ocorrencia.Obrigatoria)]
    public CategoriaLocacao Categoria { get; set; } = CategoriaLocacao.Locacao;
    
    /// <summary>
    /// Objeto da locação.
    /// </summary>
    [DFeElement(TipoCampo.Enum, "objeto", Ocorrencia = Ocorrencia.Obrigatoria)]
    public ObjetoLocacao Objeto { get; set; }

    /// <summary>
    /// Extensão total da locação.
    /// </summary>
    [DFeElement(TipoCampo.Int, "extensao", Min = 1, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int ExtensaoTotal { get; set; }
    
    /// <summary>
    /// Número de postes.
    /// </summary>
    [DFeElement(TipoCampo.Int, "nPostes", Min = 1, Max = 6, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int NumeroPostes { get; set; }
}