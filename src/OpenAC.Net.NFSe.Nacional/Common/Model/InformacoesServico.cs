﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : RFTD
// Created          : 09-09-2023
//
// Last Modified By : RFTD
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="ServicoNFSe.cs" company="OpenAC .Net">
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
/// Representa as informações do serviço para a NFSe.
/// </summary>
public sealed class InformacoesServico
{
    /// <summary>
    /// Código de Tributação Nacional (cTribNac).
    /// </summary>
    [DFeElement(TipoCampo.StrNumberFill, "cTribNac", Min = 6, Max = 6, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string CodTributacaoNacional { get; set; } = string.Empty;
    
    /// <summary>
    /// Código de Tributação do Município (cTribMun).
    /// </summary>
    [DFeElement(TipoCampo.Str, "cTribMun", Min = 3, Max = 3, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CodTributacaoMunicipio { get; set; }
    
    /// <summary>
    /// Descrição do serviço (xDescServ).
    /// </summary>
    [DFeElement(TipoCampo.Str, "xDescServ", Min = 1, Max = 2000, Ocorrencia = Ocorrencia.Obrigatoria)]
    public string Descricao { get; set; } = string.Empty;
    
    /// <summary>
    /// Código NBS (cNBS).
    /// </summary>
    [DFeElement(TipoCampo.Str, "cNBS", Min = 9, Max = 9, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CodNBS { get; set; }
    
    /// <summary>
    /// Código Interno do Contribuinte (cIntContrib).
    /// </summary>
    [DFeElement(TipoCampo.Str, "cIntContrib", Min = 1, Max = 20, Ocorrencia = Ocorrencia.NaoObrigatoria)]
    public string? CodInterno { get; set; }
}