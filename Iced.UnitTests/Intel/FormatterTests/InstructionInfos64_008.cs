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

#if (!NO_GAS_FORMATTER || !NO_INTEL_FORMATTER || !NO_MASM_FORMATTER || !NO_NASM_FORMATTER) && !NO_FORMATTER
using Iced.Intel;

namespace Iced.UnitTests.Intel.FormatterTests {
	static class InstructionInfos64_008 {
		public const int AllInfos_Length = 271;
		public static readonly InstructionInfo[] AllInfos = new InstructionInfo[AllInfos_Length] {
			new InstructionInfo(64, "62 327DCB 63 D3", Code.EVEX_Vpcompressb_zmmm512_k1z_zmm),
			new InstructionInfo(64, "62 F27D48 63 50 01", Code.EVEX_Vpcompressb_zmmm512_k1z_zmm),
			new InstructionInfo(64, "62 F2FD08 63 D3", Code.EVEX_Vpcompressw_xmmm128_k1z_xmm),
			new InstructionInfo(64, "62 F2FD08 63 50 01", Code.EVEX_Vpcompressw_xmmm128_k1z_xmm),
			new InstructionInfo(64, "62 F2FD2B 63 D3", Code.EVEX_Vpcompressw_ymmm256_k1z_ymm),
			new InstructionInfo(64, "62 F2FD2B 63 50 01", Code.EVEX_Vpcompressw_ymmm256_k1z_ymm),
			new InstructionInfo(64, "62 32FDCB 63 D3", Code.EVEX_Vpcompressw_zmmm512_k1z_zmm),
			new InstructionInfo(64, "62 F2FD48 63 50 01", Code.EVEX_Vpcompressw_zmmm512_k1z_zmm),
			new InstructionInfo(64, "62 F2CD0B 70 D3", Code.EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F2CD08 70 50 01", Code.EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F2CD2B 70 D3", Code.EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 F2CD2B 70 50 01", Code.EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 E28DCB 70 D3", Code.EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "62 F2CDCB 70 50 01", Code.EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "62 E20D0B 71 D3", Code.EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24D08 71 50 01", Code.EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24D9D 71 50 01", Code.EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 E20D2B 71 D3", Code.EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24D2B 71 50 01", Code.EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24DBD 71 50 01", Code.EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24DCB 71 D3", Code.EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24D48 71 50 01", Code.EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24DDD 71 50 01", Code.EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 E28D0B 71 D3", Code.EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 F2CD08 71 50 01", Code.EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 F2CD9D 71 50 01", Code.EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 E28D2B 71 D3", Code.EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CD2B 71 50 01", Code.EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CDBD 71 50 01", Code.EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CDCB 71 D3", Code.EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F2CD48 71 50 01", Code.EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F2CDDD 71 50 01", Code.EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F2CD0B 72 D3", Code.EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F2CD08 72 50 01", Code.EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F2CD2B 72 D3", Code.EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 F2CD2B 72 50 01", Code.EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 E28DCB 72 D3", Code.EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "62 F2CDCB 72 50 01", Code.EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "62 E20D0B 73 D3", Code.EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24D08 73 50 01", Code.EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24D9D 73 50 01", Code.EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 E20D2B 73 D3", Code.EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24D2B 73 50 01", Code.EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24DBD 73 50 01", Code.EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24DCB 73 D3", Code.EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24D48 73 50 01", Code.EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24DDD 73 50 01", Code.EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 E28D0B 73 D3", Code.EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 F2CD08 73 50 01", Code.EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 F2CD9D 73 50 01", Code.EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64),
			new InstructionInfo(64, "62 E28D2B 73 D3", Code.EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CD2B 73 50 01", Code.EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CDBD 73 50 01", Code.EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64),
			new InstructionInfo(64, "62 F2CDCB 73 D3", Code.EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F2CD48 73 50 01", Code.EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F2CDDD 73 50 01", Code.EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64),
			new InstructionInfo(64, "62 F24D0B 8F D3", Code.EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 8F 50 01", Code.EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D2B 8F D3", Code.EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D2B 8F 50 01", Code.EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D4B 8F D3", Code.EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512),
			new InstructionInfo(64, "62 F24D48 8F 50 01", Code.EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512),
			new InstructionInfo(64, "66 0F38CF CD", Code.Gf2p8mulb_xmm_xmmm128),
			new InstructionInfo(64, "66 0F38CF 08", Code.Gf2p8mulb_xmm_xmmm128),
			new InstructionInfo(64, "C4E249 CF D3", Code.VEX_Vgf2p8mulb_xmm_xmm_xmmm128),
			new InstructionInfo(64, "C4E249 CF 10", Code.VEX_Vgf2p8mulb_xmm_xmm_xmmm128),
			new InstructionInfo(64, "C4E24D CF D3", Code.VEX_Vgf2p8mulb_ymm_ymm_ymmm256),
			new InstructionInfo(64, "C4E24D CF 10", Code.VEX_Vgf2p8mulb_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D0B CF D3", Code.EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 CF 50 01", Code.EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D2B CF D3", Code.EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D2B CF 50 01", Code.EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256),
			new InstructionInfo(64, "62 E20DCB CF D3", Code.EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "62 F24DCD CF 50 01", Code.EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512),
			new InstructionInfo(64, "C4E24D DC D3", Code.VEX_Vaesenc_ymm_ymm_ymmm256),
			new InstructionInfo(64, "C4E24D DC 10", Code.VEX_Vaesenc_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D08 DC D3", Code.EVEX_Vaesenc_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 DC 50 01", Code.EVEX_Vaesenc_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D28 DC D3", Code.EVEX_Vaesenc_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D28 DC 50 01", Code.EVEX_Vaesenc_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D48 DC D3", Code.EVEX_Vaesenc_zmm_zmm_zmmm512),
			new InstructionInfo(64, "62 F24D48 DC 50 01", Code.EVEX_Vaesenc_zmm_zmm_zmmm512),
			new InstructionInfo(64, "C4E24D DD D3", Code.VEX_Vaesenclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "C4E24D DD 10", Code.VEX_Vaesenclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D08 DD D3", Code.EVEX_Vaesenclast_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 DD 50 01", Code.EVEX_Vaesenclast_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D28 DD D3", Code.EVEX_Vaesenclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D28 DD 50 01", Code.EVEX_Vaesenclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D48 DD D3", Code.EVEX_Vaesenclast_zmm_zmm_zmmm512),
			new InstructionInfo(64, "62 F24D48 DD 50 01", Code.EVEX_Vaesenclast_zmm_zmm_zmmm512),
			new InstructionInfo(64, "C4E24D DE D3", Code.VEX_Vaesdec_ymm_ymm_ymmm256),
			new InstructionInfo(64, "C4E24D DE 10", Code.VEX_Vaesdec_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D08 DE D3", Code.EVEX_Vaesdec_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 DE 50 01", Code.EVEX_Vaesdec_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D28 DE D3", Code.EVEX_Vaesdec_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D28 DE 50 01", Code.EVEX_Vaesdec_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D48 DE D3", Code.EVEX_Vaesdec_zmm_zmm_zmmm512),
			new InstructionInfo(64, "62 F24D48 DE 50 01", Code.EVEX_Vaesdec_zmm_zmm_zmmm512),
			new InstructionInfo(64, "C4E24D DF D3", Code.VEX_Vaesdeclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "C4E24D DF 10", Code.VEX_Vaesdeclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D08 DF D3", Code.EVEX_Vaesdeclast_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D08 DF 50 01", Code.EVEX_Vaesdeclast_xmm_xmm_xmmm128),
			new InstructionInfo(64, "62 F24D28 DF D3", Code.EVEX_Vaesdeclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D28 DF 50 01", Code.EVEX_Vaesdeclast_ymm_ymm_ymmm256),
			new InstructionInfo(64, "62 F24D48 DF D3", Code.EVEX_Vaesdeclast_zmm_zmm_zmmm512),
			new InstructionInfo(64, "62 F24D48 DF 50 01", Code.EVEX_Vaesdeclast_zmm_zmm_zmmm512),
			new InstructionInfo(64, "66 0F38F5 18", Code.Wrussd_m32_r32),
			new InstructionInfo(64, "66 48 0F38F5 18", Code.Wrussq_m64_r64),
			new InstructionInfo(64, "0F38F6 18", Code.Wrssd_m32_r32),
			new InstructionInfo(64, "48 0F38F6 18", Code.Wrssq_m64_r64),
			new InstructionInfo(64, "67 66 0F38F8 18", Code.Movdir64b_r32_m512),
			new InstructionInfo(64, "66 0F38F8 18", Code.Movdir64b_r64_m512),
			new InstructionInfo(64, "0F38F9 18", Code.Movdiri_m32_r32),
			new InstructionInfo(64, "48 0F38F9 18", Code.Movdiri_m64_r64),
			new InstructionInfo(64, "C4E34D 44 D3 A5", Code.VEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "C4E34D 44 10 A5", Code.VEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F34D08 44 D3 A5", Code.EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 F34D08 44 50 01 A5", Code.EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 F34D28 44 D3 A5", Code.EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F34D28 44 50 01 A5", Code.EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F34D48 44 D3 A5", Code.EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F34D48 44 50 01 A5", Code.EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F3CD0B 70 D3 A5", Code.EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 F3CD0B 70 50 01 A5", Code.EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 E38DAB 70 D3 A5", Code.EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F3CDAD 70 50 01 A5", Code.EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F3CD4B 70 D3 A5", Code.EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F3CD48 70 50 01 A5", Code.EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F34D0B 71 D3 A5", Code.EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34D0B 71 50 01 A5", Code.EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34D9D 71 50 01 A5", Code.EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34DAB 71 D3 A5", Code.EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34D28 71 50 01 A5", Code.EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34DBD 71 50 01 A5", Code.EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34D4B 71 D3 A5", Code.EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 F34D48 71 50 01 A5", Code.EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 F34DDD 71 50 01 A5", Code.EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 E38D0B 71 D3 A5", Code.EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD0B 71 50 01 A5", Code.EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD9D 71 50 01 A5", Code.EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CDAB 71 D3 A5", Code.EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CD28 71 50 01 A5", Code.EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CDBD 71 50 01 A5", Code.EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 E38D4B 71 D3 A5", Code.EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CD48 71 50 01 A5", Code.EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CDDD 71 50 01 A5", Code.EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CD0B 72 D3 A5", Code.EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 F3CD0B 72 50 01 A5", Code.EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8),
			new InstructionInfo(64, "62 E38DAB 72 D3 A5", Code.EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F3CDAD 72 50 01 A5", Code.EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 F3CD4B 72 D3 A5", Code.EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F3CD48 72 50 01 A5", Code.EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8),
			new InstructionInfo(64, "62 F34D0B 73 D3 A5", Code.EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34D0B 73 50 01 A5", Code.EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34D9D 73 50 01 A5", Code.EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8),
			new InstructionInfo(64, "62 F34DAB 73 D3 A5", Code.EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34D28 73 50 01 A5", Code.EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34DBD 73 50 01 A5", Code.EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8),
			new InstructionInfo(64, "62 F34D4B 73 D3 A5", Code.EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 F34D48 73 50 01 A5", Code.EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 F34DDD 73 50 01 A5", Code.EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8),
			new InstructionInfo(64, "62 E38D0B 73 D3 A5", Code.EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD0B 73 50 01 A5", Code.EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD9D 73 50 01 A5", Code.EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CDAB 73 D3 A5", Code.EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CD28 73 50 01 A5", Code.EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CDBD 73 50 01 A5", Code.EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 E38D4B 73 D3 A5", Code.EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CD48 73 50 01 A5", Code.EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CDDD 73 50 01 A5", Code.EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "66 0F3ACE CD A5", Code.Gf2p8affineqb_xmm_xmmm128_imm8),
			new InstructionInfo(64, "66 0F3ACE 08 A5", Code.Gf2p8affineqb_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3C9 CE D3 A5", Code.VEX_Vgf2p8affineqb_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3C9 CE 10 A5", Code.VEX_Vgf2p8affineqb_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3CD CE D3 A5", Code.VEX_Vgf2p8affineqb_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "C4E3CD CE 10 A5", Code.VEX_Vgf2p8affineqb_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 E38D0B CE D3 A5", Code.EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD0B CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD9D CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CDAB CE D3 A5", Code.EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CD28 CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CDBD CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 E38D4B CE D3 A5", Code.EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CD48 CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CDDD CE 50 01 A5", Code.EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "66 0F3ACF CD A5", Code.Gf2p8affineinvqb_xmm_xmmm128_imm8),
			new InstructionInfo(64, "66 0F3ACF 08 A5", Code.Gf2p8affineinvqb_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3C9 CF D3 A5", Code.VEX_Vgf2p8affineinvqb_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3C9 CF 10 A5", Code.VEX_Vgf2p8affineinvqb_xmm_xmm_xmmm128_imm8),
			new InstructionInfo(64, "C4E3CD CF D3 A5", Code.VEX_Vgf2p8affineinvqb_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "C4E3CD CF 10 A5", Code.VEX_Vgf2p8affineinvqb_ymm_ymm_ymmm256_imm8),
			new InstructionInfo(64, "62 E38D0B CF D3 A5", Code.EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD0B CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CD9D CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8),
			new InstructionInfo(64, "62 F3CDAB CF D3 A5", Code.EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CD28 CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 F3CDBD CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8),
			new InstructionInfo(64, "62 E38D4B CF D3 A5", Code.EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CD48 CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "62 F3CDDD CF 50 01 A5", Code.EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8),
			new InstructionInfo(64, "64 67 0F01 C8", Code.Monitord),
			new InstructionInfo(64, "64 0F01 C8", Code.Monitorq),
			new InstructionInfo(64, "64 67 0F01 FA", Code.Monitorxd),
			new InstructionInfo(64, "64 0F01 FA", Code.Monitorxq),
			new InstructionInfo(64, "64 67 0F01 FC", Code.Clzerod),
			new InstructionInfo(64, "64 0F01 FC", Code.Clzeroq),
			new InstructionInfo(64, "64 67 F3 0FAE F5", Code.Umonitor_r32),
			new InstructionInfo(64, "64 F3 0FAE F5", Code.Umonitor_r64),
			new InstructionInfo(64, "F3 0FA6 C0", Code.Montmul_64),
			new InstructionInfo(64, "67 F3 0FA6 C0", Code.Montmul_32),
			new InstructionInfo(64, "0FA6 C0", Code.Montmul_64),
			new InstructionInfo(64, "67 0FA6 C0", Code.Montmul_32),
			new InstructionInfo(64, "F3 0FA6 C8", Code.Xsha1_64),
			new InstructionInfo(64, "67 F3 0FA6 C8", Code.Xsha1_32),
			new InstructionInfo(64, "0FA6 C8", Code.Xsha1_64),
			new InstructionInfo(64, "67 0FA6 C8", Code.Xsha1_32),
			new InstructionInfo(64, "F3 0FA6 D0", Code.Xsha256_64),
			new InstructionInfo(64, "67 F3 0FA6 D0", Code.Xsha256_32),
			new InstructionInfo(64, "0FA6 D0", Code.Xsha256_64),
			new InstructionInfo(64, "67 0FA6 D0", Code.Xsha256_32),
			new InstructionInfo(64, "F3 0FA7 C0", Code.Xstore_64),
			new InstructionInfo(64, "67 F3 0FA7 C0", Code.Xstore_32),
			new InstructionInfo(64, "0FA7 C0", Code.Xstore_64),
			new InstructionInfo(64, "67 0FA7 C0", Code.Xstore_32),
			new InstructionInfo(64, "F3 0FA7 C8", Code.XcryptEcb_64),
			new InstructionInfo(64, "67 F3 0FA7 C8", Code.XcryptEcb_32),
			new InstructionInfo(64, "0FA7 C8", Code.XcryptEcb_64),
			new InstructionInfo(64, "67 0FA7 C8", Code.XcryptEcb_32),
			new InstructionInfo(64, "F3 0FA7 D0", Code.XcryptCbc_64),
			new InstructionInfo(64, "67 F3 0FA7 D0", Code.XcryptCbc_32),
			new InstructionInfo(64, "0FA7 D0", Code.XcryptCbc_64),
			new InstructionInfo(64, "67 0FA7 D0", Code.XcryptCbc_32),
			new InstructionInfo(64, "F3 0FA7 D8", Code.XcryptCtr_64),
			new InstructionInfo(64, "67 F3 0FA7 D8", Code.XcryptCtr_32),
			new InstructionInfo(64, "0FA7 D8", Code.XcryptCtr_64),
			new InstructionInfo(64, "67 0FA7 D8", Code.XcryptCtr_32),
			new InstructionInfo(64, "F3 0FA7 E0", Code.XcryptCfb_64),
			new InstructionInfo(64, "67 F3 0FA7 E0", Code.XcryptCfb_32),
			new InstructionInfo(64, "0FA7 E0", Code.XcryptCfb_64),
			new InstructionInfo(64, "67 0FA7 E0", Code.XcryptCfb_32),
			new InstructionInfo(64, "F3 0FA7 E8", Code.XcryptOfb_64),
			new InstructionInfo(64, "67 F3 0FA7 E8", Code.XcryptOfb_32),
			new InstructionInfo(64, "0FA7 E8", Code.XcryptOfb_64),
			new InstructionInfo(64, "67 0FA7 E8", Code.XcryptOfb_32),
			new InstructionInfo(64, "62 E20E0B 52 D3", Code.EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24E08 52 50 01", Code.EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24E9D 52 50 01", Code.EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 E20E2B 52 D3", Code.EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24E2B 52 50 01", Code.EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24EBD 52 50 01", Code.EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24ECB 52 D3", Code.EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24E48 52 50 01", Code.EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24EDD 52 50 01", Code.EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F27E8B 72 D3", Code.EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32),
			new InstructionInfo(64, "62 F27E0B 72 50 01", Code.EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32),
			new InstructionInfo(64, "62 F27E9D 72 50 01", Code.EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32),
			new InstructionInfo(64, "62 F27EAB 72 D3", Code.EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32),
			new InstructionInfo(64, "62 F27E2B 72 50 01", Code.EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32),
			new InstructionInfo(64, "62 F27EBD 72 50 01", Code.EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32),
			new InstructionInfo(64, "62 F27ECB 72 D3", Code.EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32),
			new InstructionInfo(64, "62 F27E4B 72 50 01", Code.EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32),
			new InstructionInfo(64, "62 F27EDD 72 50 01", Code.EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32),
			new InstructionInfo(64, "62 E20F0B 72 D3", Code.EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24F08 72 50 01", Code.EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 F24F9D 72 50 01", Code.EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32),
			new InstructionInfo(64, "62 E20F2B 72 D3", Code.EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24F2B 72 50 01", Code.EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24FBD 72 50 01", Code.EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32),
			new InstructionInfo(64, "62 F24FCB 72 D3", Code.EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24F48 72 50 01", Code.EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32),
			new InstructionInfo(64, "62 F24FDD 72 50 01", Code.EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32),
		};
	}
}
#endif
