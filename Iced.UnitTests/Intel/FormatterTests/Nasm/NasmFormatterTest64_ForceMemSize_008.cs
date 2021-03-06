/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest64_ForceMemSize_008 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_008.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_008.AllInfos_Length] {
			"vpcompressb zmm19{k3}{z},zmm10",
			"vpcompressb zword [rax+1],zmm2",
			"vpcompressw xmm3,xmm2",
			"vpcompressw oword [rax+2],xmm2",
			"vpcompressw ymm3{k3},ymm2",
			"vpcompressw yword [rax+2]{k3},ymm2",
			"vpcompressw zmm19{k3}{z},zmm10",
			"vpcompressw zword [rax+2],zmm2",
			"vpshldvw xmm2{k3},xmm6,xmm3",
			"vpshldvw xmm2,xmm6,oword [rax+0x10]",
			"vpshldvw ymm2{k3},ymm6,ymm3",
			"vpshldvw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshldvw zmm18{k3}{z},zmm14,zmm3",
			"vpshldvw zmm2{k3}{z},zmm6,zword [rax+0x40]",
			"vpshldvd xmm18{k3},xmm14,xmm3",
			"vpshldvd xmm2,xmm6,oword [rax+0x10]",
			"vpshldvd xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpshldvd ymm18{k3},ymm14,ymm3",
			"vpshldvd ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshldvd ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpshldvd zmm2{k3}{z},zmm6,zmm3",
			"vpshldvd zmm2,zmm6,zword [rax+0x40]",
			"vpshldvd zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vpshldvq xmm18{k3},xmm14,xmm3",
			"vpshldvq xmm2,xmm6,oword [rax+0x10]",
			"vpshldvq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpshldvq ymm18{k3},ymm14,ymm3",
			"vpshldvq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshldvq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpshldvq zmm2{k3}{z},zmm6,zmm3",
			"vpshldvq zmm2,zmm6,zword [rax+0x40]",
			"vpshldvq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"vpshrdvw xmm2{k3},xmm6,xmm3",
			"vpshrdvw xmm2,xmm6,oword [rax+0x10]",
			"vpshrdvw ymm2{k3},ymm6,ymm3",
			"vpshrdvw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshrdvw zmm18{k3}{z},zmm14,zmm3",
			"vpshrdvw zmm2{k3}{z},zmm6,zword [rax+0x40]",
			"vpshrdvd xmm18{k3},xmm14,xmm3",
			"vpshrdvd xmm2,xmm6,oword [rax+0x10]",
			"vpshrdvd xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpshrdvd ymm18{k3},ymm14,ymm3",
			"vpshrdvd ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshrdvd ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpshrdvd zmm2{k3}{z},zmm6,zmm3",
			"vpshrdvd zmm2,zmm6,zword [rax+0x40]",
			"vpshrdvd zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vpshrdvq xmm18{k3},xmm14,xmm3",
			"vpshrdvq xmm2,xmm6,oword [rax+0x10]",
			"vpshrdvq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpshrdvq ymm18{k3},ymm14,ymm3",
			"vpshrdvq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpshrdvq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpshrdvq zmm2{k3}{z},zmm6,zmm3",
			"vpshrdvq zmm2,zmm6,zword [rax+0x40]",
			"vpshrdvq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"vpshufbitqmb k2{k3},xmm6,xmm3",
			"vpshufbitqmb k2,xmm6,oword [rax+0x10]",
			"vpshufbitqmb k2{k3},ymm6,ymm3",
			"vpshufbitqmb k2{k3},ymm6,yword [rax+0x20]",
			"vpshufbitqmb k2{k3},zmm6,zmm3",
			"vpshufbitqmb k2,zmm6,zword [rax+0x40]",
			"gf2p8mulb xmm1,xmm5",
			"gf2p8mulb xmm1,oword [rax]",
			"vgf2p8mulb xmm2,xmm6,xmm3",
			"vgf2p8mulb xmm2,xmm6,oword [rax]",
			"vgf2p8mulb ymm2,ymm6,ymm3",
			"vgf2p8mulb ymm2,ymm6,yword [rax]",
			"vgf2p8mulb xmm2{k3},xmm6,xmm3",
			"vgf2p8mulb xmm2,xmm6,oword [rax+0x10]",
			"vgf2p8mulb ymm2{k3},ymm6,ymm3",
			"vgf2p8mulb ymm2{k3},ymm6,yword [rax+0x20]",
			"vgf2p8mulb zmm18{k3}{z},zmm14,zmm3",
			"vgf2p8mulb zmm2{k5}{z},zmm6,zword [rax+0x40]",
			"vaesenc ymm2,ymm6,ymm3",
			"vaesenc ymm2,ymm6,yword [rax]",
			"vaesenc xmm2,xmm6,xmm3",
			"vaesenc xmm2,xmm6,oword [rax+0x10]",
			"vaesenc ymm2,ymm6,ymm3",
			"vaesenc ymm2,ymm6,yword [rax+0x20]",
			"vaesenc zmm2,zmm6,zmm3",
			"vaesenc zmm2,zmm6,zword [rax+0x40]",
			"vaesenclast ymm2,ymm6,ymm3",
			"vaesenclast ymm2,ymm6,yword [rax]",
			"vaesenclast xmm2,xmm6,xmm3",
			"vaesenclast xmm2,xmm6,oword [rax+0x10]",
			"vaesenclast ymm2,ymm6,ymm3",
			"vaesenclast ymm2,ymm6,yword [rax+0x20]",
			"vaesenclast zmm2,zmm6,zmm3",
			"vaesenclast zmm2,zmm6,zword [rax+0x40]",
			"vaesdec ymm2,ymm6,ymm3",
			"vaesdec ymm2,ymm6,yword [rax]",
			"vaesdec xmm2,xmm6,xmm3",
			"vaesdec xmm2,xmm6,oword [rax+0x10]",
			"vaesdec ymm2,ymm6,ymm3",
			"vaesdec ymm2,ymm6,yword [rax+0x20]",
			"vaesdec zmm2,zmm6,zmm3",
			"vaesdec zmm2,zmm6,zword [rax+0x40]",
			"vaesdeclast ymm2,ymm6,ymm3",
			"vaesdeclast ymm2,ymm6,yword [rax]",
			"vaesdeclast xmm2,xmm6,xmm3",
			"vaesdeclast xmm2,xmm6,oword [rax+0x10]",
			"vaesdeclast ymm2,ymm6,ymm3",
			"vaesdeclast ymm2,ymm6,yword [rax+0x20]",
			"vaesdeclast zmm2,zmm6,zmm3",
			"vaesdeclast zmm2,zmm6,zword [rax+0x40]",
			"wrussd dword [rax],ebx",
			"wrussq qword [rax],rbx",
			"wrssd dword [rax],ebx",
			"wrssq qword [rax],rbx",
			"movdir64b ebx,zword [eax]",
			"movdir64b rbx,zword [rax]",
			"movdiri dword [rax],ebx",
			"movdiri qword [rax],rbx",
			"vpclmulqdq ymm2,ymm6,ymm3,-0x5b",
			"vpclmulqdq ymm2,ymm6,yword [rax],-0x5b",
			"vpclmulqdq xmm2,xmm6,xmm3,-0x5b",
			"vpclmulqdq xmm2,xmm6,oword [rax+0x10],-0x5b",
			"vpclmulqdq ymm2,ymm6,ymm3,-0x5b",
			"vpclmulqdq ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vpclmulqdq zmm2,zmm6,zmm3,-0x5b",
			"vpclmulqdq zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshldw xmm2{k3},xmm6,xmm3,-0x5b",
			"vpshldw xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshldw ymm18{k3}{z},ymm14,ymm3,-0x5b",
			"vpshldw ymm2{k5}{z},ymm6,yword [rax+0x20],-0x5b",
			"vpshldw zmm2{k3},zmm6,zmm3,-0x5b",
			"vpshldw zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshldd xmm2{k3},xmm6,xmm3,-0x5b",
			"vpshldd xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshldd xmm2{k5}{z},xmm6,dword [rax+4]{1to4},-0x5b",
			"vpshldd ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vpshldd ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vpshldd ymm2{k5}{z},ymm6,dword [rax+4]{1to8},-0x5b",
			"vpshldd zmm2{k3},zmm6,zmm3,-0x5b",
			"vpshldd zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshldd zmm2{k5}{z},zmm6,dword [rax+4]{1to16},-0x5b",
			"vpshldq xmm18{k3},xmm14,xmm3,-0x5b",
			"vpshldq xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshldq xmm2{k5}{z},xmm6,qword [rax+8]{1to2},-0x5b",
			"vpshldq ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vpshldq ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vpshldq ymm2{k5}{z},ymm6,qword [rax+8]{1to4},-0x5b",
			"vpshldq zmm18{k3},zmm14,zmm3,-0x5b",
			"vpshldq zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshldq zmm2{k5}{z},zmm6,qword [rax+8]{1to8},-0x5b",
			"vpshrdw xmm2{k3},xmm6,xmm3,-0x5b",
			"vpshrdw xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshrdw ymm18{k3}{z},ymm14,ymm3,-0x5b",
			"vpshrdw ymm2{k5}{z},ymm6,yword [rax+0x20],-0x5b",
			"vpshrdw zmm2{k3},zmm6,zmm3,-0x5b",
			"vpshrdw zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshrdd xmm2{k3},xmm6,xmm3,-0x5b",
			"vpshrdd xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshrdd xmm2{k5}{z},xmm6,dword [rax+4]{1to4},-0x5b",
			"vpshrdd ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vpshrdd ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vpshrdd ymm2{k5}{z},ymm6,dword [rax+4]{1to8},-0x5b",
			"vpshrdd zmm2{k3},zmm6,zmm3,-0x5b",
			"vpshrdd zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshrdd zmm2{k5}{z},zmm6,dword [rax+4]{1to16},-0x5b",
			"vpshrdq xmm18{k3},xmm14,xmm3,-0x5b",
			"vpshrdq xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vpshrdq xmm2{k5}{z},xmm6,qword [rax+8]{1to2},-0x5b",
			"vpshrdq ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vpshrdq ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vpshrdq ymm2{k5}{z},ymm6,qword [rax+8]{1to4},-0x5b",
			"vpshrdq zmm18{k3},zmm14,zmm3,-0x5b",
			"vpshrdq zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vpshrdq zmm2{k5}{z},zmm6,qword [rax+8]{1to8},-0x5b",
			"gf2p8affineqb xmm1,xmm5,-0x5b",
			"gf2p8affineqb xmm1,oword [rax],-0x5b",
			"vgf2p8affineqb xmm2,xmm6,xmm3,-0x5b",
			"vgf2p8affineqb xmm2,xmm6,oword [rax],-0x5b",
			"vgf2p8affineqb ymm2,ymm6,ymm3,-0x5b",
			"vgf2p8affineqb ymm2,ymm6,yword [rax],-0x5b",
			"vgf2p8affineqb xmm18{k3},xmm14,xmm3,-0x5b",
			"vgf2p8affineqb xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vgf2p8affineqb xmm2{k5}{z},xmm6,qword [rax+8]{1to2},-0x5b",
			"vgf2p8affineqb ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vgf2p8affineqb ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vgf2p8affineqb ymm2{k5}{z},ymm6,qword [rax+8]{1to4},-0x5b",
			"vgf2p8affineqb zmm18{k3},zmm14,zmm3,-0x5b",
			"vgf2p8affineqb zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vgf2p8affineqb zmm2{k5}{z},zmm6,qword [rax+8]{1to8},-0x5b",
			"gf2p8affineinvqb xmm1,xmm5,-0x5b",
			"gf2p8affineinvqb xmm1,oword [rax],-0x5b",
			"vgf2p8affineinvqb xmm2,xmm6,xmm3,-0x5b",
			"vgf2p8affineinvqb xmm2,xmm6,oword [rax],-0x5b",
			"vgf2p8affineinvqb ymm2,ymm6,ymm3,-0x5b",
			"vgf2p8affineinvqb ymm2,ymm6,yword [rax],-0x5b",
			"vgf2p8affineinvqb xmm18{k3},xmm14,xmm3,-0x5b",
			"vgf2p8affineinvqb xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vgf2p8affineinvqb xmm2{k5}{z},xmm6,qword [rax+8]{1to2},-0x5b",
			"vgf2p8affineinvqb ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vgf2p8affineinvqb ymm2,ymm6,yword [rax+0x20],-0x5b",
			"vgf2p8affineinvqb ymm2{k5}{z},ymm6,qword [rax+8]{1to4},-0x5b",
			"vgf2p8affineinvqb zmm18{k3},zmm14,zmm3,-0x5b",
			"vgf2p8affineinvqb zmm2,zmm6,zword [rax+0x40],-0x5b",
			"vgf2p8affineinvqb zmm2{k5}{z},zmm6,qword [rax+8]{1to8},-0x5b",
			"a32 fs monitor",
			"fs monitor",
			"a32 fs monitorx",
			"fs monitorx",
			"a32 fs clzero",
			"fs clzero",
			"fs umonitor ebp",
			"fs umonitor rbp",
			"rep montmul",
			"a32 rep montmul",
			"montmul",
			"a32 montmul",
			"rep xsha1",
			"a32 rep xsha1",
			"xsha1",
			"a32 xsha1",
			"rep xsha256",
			"a32 rep xsha256",
			"xsha256",
			"a32 xsha256",
			"rep xstore",
			"a32 rep xstore",
			"xstore",
			"a32 xstore",
			"rep xcryptecb",
			"a32 rep xcryptecb",
			"xcryptecb",
			"a32 xcryptecb",
			"rep xcryptcbc",
			"a32 rep xcryptcbc",
			"xcryptcbc",
			"a32 xcryptcbc",
			"rep xcryptctr",
			"a32 rep xcryptctr",
			"xcryptctr",
			"a32 xcryptctr",
			"rep xcryptcfb",
			"a32 rep xcryptcfb",
			"xcryptcfb",
			"a32 xcryptcfb",
			"rep xcryptofb",
			"a32 rep xcryptofb",
			"xcryptofb",
			"a32 xcryptofb",
			"vdpbf16ps xmm18{k3},xmm14,xmm3",
			"vdpbf16ps xmm2,xmm6,oword [rax+0x10]",
			"vdpbf16ps xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vdpbf16ps ymm18{k3},ymm14,ymm3",
			"vdpbf16ps ymm2{k3},ymm6,yword [rax+0x20]",
			"vdpbf16ps ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vdpbf16ps zmm2{k3}{z},zmm6,zmm3",
			"vdpbf16ps zmm2,zmm6,zword [rax+0x40]",
			"vdpbf16ps zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vcvtneps2bf16 xmm2{k3}{z},xmm3",
			"vcvtneps2bf16 xmm2{k3},oword [rax+0x10]",
			"vcvtneps2bf16 xmm2{k5}{z},dword [rax+4]{1to4}",
			"vcvtneps2bf16 xmm2{k3}{z},ymm3",
			"vcvtneps2bf16 xmm2{k3},yword [rax+0x20]",
			"vcvtneps2bf16 xmm2{k5}{z},dword [rax+4]{1to8}",
			"vcvtneps2bf16 ymm2{k3}{z},zmm3",
			"vcvtneps2bf16 ymm2{k3},zword [rax+0x40]",
			"vcvtneps2bf16 ymm2{k5}{z},dword [rax+4]{1to16}",
			"vcvtne2ps2bf16 xmm18{k3},xmm14,xmm3",
			"vcvtne2ps2bf16 xmm2,xmm6,oword [rax+0x10]",
			"vcvtne2ps2bf16 xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vcvtne2ps2bf16 ymm18{k3},ymm14,ymm3",
			"vcvtne2ps2bf16 ymm2{k3},ymm6,yword [rax+0x20]",
			"vcvtne2ps2bf16 ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vcvtne2ps2bf16 zmm2{k3}{z},zmm6,zmm3",
			"vcvtne2ps2bf16 zmm2,zmm6,zword [rax+0x40]",
			"vcvtne2ps2bf16 zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
		};
	}
}
#endif
