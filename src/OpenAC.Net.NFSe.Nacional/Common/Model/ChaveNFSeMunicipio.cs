﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="ChaveNFSeMunicipio.cs" company="OpenAC .Net">
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

namespace OpenAC.Net.NFSe.Nacional.Common.Model;

/// <summary>
/// Representa a chave de identificação de uma NFSe no município.
/// </summary>
public sealed class ChaveNFSeMunicipio
{
    /// <summary>
    /// Código do município (7 dígitos).
    /// </summary>
    [DFeElement(TipoCampo.Str, "cMunNFSeMun", Min = 7, Max = 7, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string CodMunicipio { get; set; } = string.Empty;
    
    /// <summary>
    /// Número da NFSe (1 a 15 dígitos).
    /// </summary>
    [DFeElement(TipoCampo.Str, "nNFSeMun", Min = 1, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
    public int Numero { get; set; }
    
    /// <summary>
    /// Código de verificação da NFSe (1 a 9 caracteres).
    /// </summary>
    [DFeElement(TipoCampo.Str, "cVerifNFSeMun", Min = 1, Max = 9, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string CodVerificacao { get; set; } = string.Empty;
}