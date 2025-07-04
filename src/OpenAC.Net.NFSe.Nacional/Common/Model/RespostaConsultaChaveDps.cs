﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe.Nacional
// Author           : Rafael Dias
// Created          : 30-10-2024
//
// Last Modified By : Rafael Dias
// Last Modified On : 30-10-2024
// ***********************************************************************
// <copyright file="RespostaConsultaChaveDps.cs" company="OpenAC .Net">
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

using System.Text.Json.Serialization;

namespace OpenAC.Net.NFSe.Nacional.Common.Model;

/// <summary>
/// Representa a resposta da consulta por chave de DPS.
/// </summary>
public sealed class RespostaConsultaChaveDps : RespostaBase
{
    /// <summary>
    /// Identificador da DPS.
    /// </summary>
    [JsonPropertyName("idDps")]
    public string IdDps { get; set; } = string.Empty;
    
    /// <summary>
    /// Chave de acesso da DPS.
    /// </summary>
    [JsonPropertyName("chaveAcesso")]
    public string Chave { get; set; } = string.Empty;
}