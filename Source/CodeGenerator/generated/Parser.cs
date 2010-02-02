// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2008
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  COREDUO
// DateTime: 2.2.2010 18:32:25
// UserName: Jakub
// Input file <generators\Parser.y>

// options: babel no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using linqtoweb.CodeGenerator.AST;

namespace linqtoweb.CodeGenerator
{
public enum Tokens {
    error=1,EOF=2,CLASS=3,FOREACH=4,IDENTIFIER=5,DOTTEDIDENTIFIER=6,
    LPAREN=7,RPAREN=8,LBRACE=9,RBRACE=10,LBRACKET=11,RBRACKET=12,
    TSTRING=13,TINT=14,TDOUBLE=15,TDATETIME=16,TBOOL=17,STRINGVAL=18,
    INTEGERVAL=19,DOUBLEVAL=20,BOOLVAL=21,OP_ADD=22,OP_SUB=23,OP_MUL=24,
    OP_DIV=25,OP_ASSIGN=26,OP_ADD1=27,OP_SUB1=28,OP_LOGIC_OR=29,OP_LOGIC_AND=30,
    OP_LOGIC_XOR=31,OP_LOGIC_NOT=32,OP_EQ=33,OP_NOTEQ=34,OP_LESS=35,OP_GREATER=36,
    OP_LESSEQ=37,OP_GREATEREQ=38,OP_QUESTION=39,OP_COLON=40,COMMA=41,SEMICOLON=42,
    WHITESPACE=43,COMMENT=44};

public struct ValueType
{
	public Object obj;
}
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,ExprPosition> {
  private ExprPosition __yylloc = new ExprPosition();
  public override ExprPosition yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }

  protected abstract int CurrentSc { get; set; }
  //
  // Override the virtual EolState property if the scanner state is more
  // complicated then a simple copy of the current start state ordinal
  //
  public virtual int EolState { get { return CurrentSc; } set { CurrentSc = value; } }
}

// Interface class for 'colorizing' scanners
public interface IColorScan {
  void SetSource(string source, int offset);
  int GetNext(ref int state, out int start, out int end);
}

public class Parser: ShiftReduceParser<ValueType, ExprPosition>
{
#pragma warning disable 649
    private Dictionary<int, string> aliasses;
#pragma warning restore 649

  protected override void Initialize()
  {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);

    this.InitStateTable(143);
    AddState(0,new State(new int[]{3,6,5,27,7,138,2,142},new int[]{-1,1,-3,3,-4,4,-5,25}));
    AddState(1,new State(new int[]{2,2}));
    AddState(2,new State(-1));
    AddState(3,new State(-2));
    AddState(4,new State(new int[]{3,6,5,27,7,138,2,142},new int[]{-3,5,-4,4,-5,25}));
    AddState(5,new State(-3));
    AddState(6,new State(new int[]{5,7}));
    AddState(7,new State(new int[]{9,8}));
    AddState(8,new State(new int[]{13,19,14,20,15,21,16,22,17,23,5,24,10,-8},new int[]{-6,9,-7,11,-8,15,-9,18}));
    AddState(9,new State(new int[]{10,10}));
    AddState(10,new State(-6));
    AddState(11,new State(new int[]{5,12}));
    AddState(12,new State(new int[]{42,13}));
    AddState(13,new State(new int[]{13,19,14,20,15,21,16,22,17,23,5,24,10,-8},new int[]{-6,14,-7,11,-8,15,-9,18}));
    AddState(14,new State(-7));
    AddState(15,new State(new int[]{11,16,5,-9}));
    AddState(16,new State(new int[]{12,17}));
    AddState(17,new State(-10));
    AddState(18,new State(-16));
    AddState(19,new State(-11));
    AddState(20,new State(-12));
    AddState(21,new State(-13));
    AddState(22,new State(-14));
    AddState(23,new State(-15));
    AddState(24,new State(-17));
    AddState(25,new State(new int[]{3,6,5,27,7,138,2,142},new int[]{-3,26,-4,4,-5,25}));
    AddState(26,new State(-4));
    AddState(27,new State(new int[]{7,28}));
    AddState(28,new State(new int[]{13,19,14,20,15,21,16,22,17,23,5,24,8,-22},new int[]{-10,29,-7,134,-8,15,-9,18}));
    AddState(29,new State(new int[]{8,30}));
    AddState(30,new State(new int[]{11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129},new int[]{-11,31,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(31,new State(-18));
    AddState(32,new State(new int[]{11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129},new int[]{-11,33,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(33,new State(-24));
    AddState(34,new State(new int[]{5,37},new int[]{-13,35}));
    AddState(35,new State(new int[]{12,36}));
    AddState(36,new State(-23));
    AddState(37,new State(new int[]{7,38}));
    AddState(38,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,8,-74},new int[]{-23,39,-24,41,-16,42,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(39,new State(new int[]{8,40}));
    AddState(40,new State(-72));
    AddState(41,new State(-73));
    AddState(42,new State(new int[]{29,43,30,74,31,94,39,96,41,111,8,-75}));
    AddState(43,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-17,44,-19,93,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(44,new State(new int[]{33,45,34,76,35,85,36,87,37,89,38,91,42,-35,29,-35,30,-35,31,-35,39,-35,41,-35,8,-35,40,-35}));
    AddState(45,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,46,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(46,new State(new int[]{22,47,23,78,33,-42,34,-42,35,-42,36,-42,37,-42,38,-42,42,-42,29,-42,30,-42,31,-42,39,-42,41,-42,8,-42,40,-42}));
    AddState(47,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-20,48,-21,83,-18,53,-22,56,-13,82}));
    AddState(48,new State(new int[]{24,49,25,80,22,-49,23,-49,33,-49,34,-49,35,-49,36,-49,37,-49,38,-49,42,-49,29,-49,30,-49,31,-49,39,-49,41,-49,8,-49,40,-49}));
    AddState(49,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,50,-18,53,-22,56,-13,82}));
    AddState(50,new State(new int[]{28,51,27,52,24,-52,25,-52,22,-52,23,-52,33,-52,34,-52,35,-52,36,-52,37,-52,38,-52,42,-52,29,-52,30,-52,31,-52,39,-52,41,-52,8,-52,40,-52}));
    AddState(51,new State(-61));
    AddState(52,new State(-62));
    AddState(53,new State(-54));
    AddState(54,new State(new int[]{7,38,26,-66,11,-66,28,-66,27,-66,24,-66,25,-66,22,-66,23,-66,33,-66,34,-66,35,-66,36,-66,37,-66,38,-66,29,-66,30,-66,31,-66,39,-66,41,-66,8,-66,42,-66,40,-66}));
    AddState(55,new State(-67));
    AddState(56,new State(-55));
    AddState(57,new State(-68));
    AddState(58,new State(-69));
    AddState(59,new State(-70));
    AddState(60,new State(-71));
    AddState(61,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,62,-18,53,-22,56,-13,82}));
    AddState(62,new State(-56));
    AddState(63,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,64,-18,53,-22,56,-13,82}));
    AddState(64,new State(new int[]{28,51,27,52,24,-57,25,-57,22,-57,23,-57,33,-57,34,-57,35,-57,36,-57,37,-57,38,-57,42,-57,29,-57,30,-57,31,-57,39,-57,41,-57,8,-57,40,-57}));
    AddState(65,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,66,-18,53,-22,56,-13,82}));
    AddState(66,new State(new int[]{28,51,27,52,24,-58,25,-58,22,-58,23,-58,33,-58,34,-58,35,-58,36,-58,37,-58,38,-58,42,-58,29,-58,30,-58,31,-58,39,-58,41,-58,8,-58,40,-58}));
    AddState(67,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,68,-18,53,-22,56,-13,82}));
    AddState(68,new State(-59));
    AddState(69,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,70,-18,53,-22,56,-13,82}));
    AddState(70,new State(new int[]{28,51,27,-60,24,-60,25,-60,22,-60,23,-60,33,-60,34,-60,35,-60,36,-60,37,-60,38,-60,42,-60,29,-60,30,-60,31,-60,39,-60,41,-60,8,-60,40,-60}));
    AddState(71,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,13,19,14,20,15,21,16,22,17,23},new int[]{-16,72,-9,108,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(72,new State(new int[]{8,73,29,43,30,74,31,94,39,96}));
    AddState(73,new State(-63));
    AddState(74,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-17,75,-19,93,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(75,new State(new int[]{33,45,34,76,35,85,36,87,37,89,38,91,42,-36,29,-36,30,-36,31,-36,39,-36,41,-36,8,-36,40,-36}));
    AddState(76,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,77,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(77,new State(new int[]{22,47,23,78,33,-43,34,-43,35,-43,36,-43,37,-43,38,-43,42,-43,29,-43,30,-43,31,-43,39,-43,41,-43,8,-43,40,-43}));
    AddState(78,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-20,79,-21,83,-18,53,-22,56,-13,82}));
    AddState(79,new State(new int[]{24,49,25,80,22,-50,23,-50,33,-50,34,-50,35,-50,36,-50,37,-50,38,-50,42,-50,29,-50,30,-50,31,-50,39,-50,41,-50,8,-50,40,-50}));
    AddState(80,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,81,-18,53,-22,56,-13,82}));
    AddState(81,new State(new int[]{28,51,27,52,24,-53,25,-53,22,-53,23,-53,33,-53,34,-53,35,-53,36,-53,37,-53,38,-53,42,-53,29,-53,30,-53,31,-53,39,-53,41,-53,8,-53,40,-53}));
    AddState(82,new State(-65));
    AddState(83,new State(new int[]{28,51,27,52,24,-51,25,-51,22,-51,23,-51,33,-51,34,-51,35,-51,36,-51,37,-51,38,-51,42,-51,29,-51,30,-51,31,-51,39,-51,41,-51,8,-51,40,-51}));
    AddState(84,new State(new int[]{24,49,25,80,22,-48,23,-48,33,-48,34,-48,35,-48,36,-48,37,-48,38,-48,42,-48,29,-48,30,-48,31,-48,39,-48,41,-48,8,-48,40,-48}));
    AddState(85,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,86,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(86,new State(new int[]{22,47,23,78,33,-44,34,-44,35,-44,36,-44,37,-44,38,-44,42,-44,29,-44,30,-44,31,-44,39,-44,41,-44,8,-44,40,-44}));
    AddState(87,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,88,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(88,new State(new int[]{22,47,23,78,33,-45,34,-45,35,-45,36,-45,37,-45,38,-45,42,-45,29,-45,30,-45,31,-45,39,-45,41,-45,8,-45,40,-45}));
    AddState(89,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,90,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(90,new State(new int[]{22,47,23,78,33,-46,34,-46,35,-46,36,-46,37,-46,38,-46,42,-46,29,-46,30,-46,31,-46,39,-46,41,-46,8,-46,40,-46}));
    AddState(91,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-19,92,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(92,new State(new int[]{22,47,23,78,33,-47,34,-47,35,-47,36,-47,37,-47,38,-47,42,-47,29,-47,30,-47,31,-47,39,-47,41,-47,8,-47,40,-47}));
    AddState(93,new State(new int[]{22,47,23,78,33,-41,34,-41,35,-41,36,-41,37,-41,38,-41,42,-41,29,-41,30,-41,31,-41,39,-41,41,-41,8,-41,40,-41}));
    AddState(94,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-17,95,-19,93,-20,84,-21,83,-18,53,-22,56,-13,82}));
    AddState(95,new State(new int[]{33,45,34,76,35,85,36,87,37,89,38,91,42,-37,29,-37,30,-37,31,-37,39,-37,41,-37,8,-37,40,-37}));
    AddState(96,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,97,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(97,new State(new int[]{40,98,29,43,30,74,31,94,39,96}));
    AddState(98,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,99,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(99,new State(new int[]{29,43,30,74,31,94,39,-38,42,-38,41,-38,8,-38,40,-38}));
    AddState(100,new State(new int[]{33,45,34,76,35,85,36,87,37,89,38,91,42,-34,29,-34,30,-34,31,-34,39,-34,41,-34,8,-34,40,-34}));
    AddState(101,new State(new int[]{26,102,11,104,28,-54,27,-54,24,-54,25,-54,22,-54,23,-54,33,-54,34,-54,35,-54,36,-54,37,-54,38,-54,42,-54,29,-54,30,-54,31,-54,39,-54,41,-54,8,-54,40,-54}));
    AddState(102,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,103,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(103,new State(new int[]{29,43,30,74,31,94,39,96,42,-39,41,-39,8,-39,40,-39}));
    AddState(104,new State(new int[]{12,105}));
    AddState(105,new State(new int[]{26,106}));
    AddState(106,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,107,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(107,new State(new int[]{29,43,30,74,31,94,39,96,42,-40,41,-40,8,-40,40,-40}));
    AddState(108,new State(new int[]{8,109}));
    AddState(109,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-21,110,-18,53,-22,56,-13,82}));
    AddState(110,new State(-64));
    AddState(111,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-24,112,-16,42,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(112,new State(-76));
    AddState(113,new State(-25));
    AddState(114,new State(-28));
    AddState(115,new State(new int[]{5,116}));
    AddState(116,new State(new int[]{26,117}));
    AddState(117,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,118,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(118,new State(new int[]{42,119,29,43,30,74,31,94,39,96}));
    AddState(119,new State(-29));
    AddState(120,new State(new int[]{7,38,5,-17,26,-66,11,-66,28,-66,27,-66,24,-66,25,-66,22,-66,23,-66,33,-66,34,-66,35,-66,36,-66,37,-66,38,-66,42,-66,29,-66,30,-66,31,-66,39,-66}));
    AddState(121,new State(new int[]{42,122,29,43,30,74,31,94,39,96}));
    AddState(122,new State(-30));
    AddState(123,new State(new int[]{10,124,11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129},new int[]{-15,125,-11,127,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(124,new State(-31));
    AddState(125,new State(new int[]{10,126}));
    AddState(126,new State(-32));
    AddState(127,new State(new int[]{11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129,10,-27},new int[]{-15,128,-11,127,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(128,new State(-26));
    AddState(129,new State(new int[]{7,130}));
    AddState(130,new State(new int[]{5,54,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71},new int[]{-16,131,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(131,new State(new int[]{8,132,29,43,30,74,31,94,39,96}));
    AddState(132,new State(new int[]{11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129},new int[]{-11,133,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(133,new State(-33));
    AddState(134,new State(new int[]{5,135}));
    AddState(135,new State(new int[]{41,136,8,-21}));
    AddState(136,new State(new int[]{13,19,14,20,15,21,16,22,17,23,5,24,8,-22},new int[]{-10,137,-7,134,-8,15,-9,18}));
    AddState(137,new State(-20));
    AddState(138,new State(new int[]{13,19,14,20,15,21,16,22,17,23,5,24,8,-22},new int[]{-10,139,-7,134,-8,15,-9,18}));
    AddState(139,new State(new int[]{8,140}));
    AddState(140,new State(new int[]{11,34,42,114,13,19,14,20,15,21,16,22,17,23,5,120,6,55,18,57,19,58,20,59,21,60,32,61,23,63,22,65,28,67,27,69,7,71,9,123,4,129},new int[]{-11,141,-12,32,-14,113,-8,115,-9,18,-16,121,-17,100,-19,93,-20,84,-21,83,-18,101,-22,56,-13,82}));
    AddState(141,new State(-19));
    AddState(142,new State(-5));

    Rule[] rules=new Rule[77];
    rules[1]=new Rule(-2, new int[]{-1,2});
    rules[2]=new Rule(-1, new int[]{-3});
    rules[3]=new Rule(-3, new int[]{-4,-3});
    rules[4]=new Rule(-3, new int[]{-5,-3});
    rules[5]=new Rule(-3, new int[]{2});
    rules[6]=new Rule(-4, new int[]{3,5,9,-6,10});
    rules[7]=new Rule(-6, new int[]{-7,5,42,-6});
    rules[8]=new Rule(-6, new int[]{});
    rules[9]=new Rule(-7, new int[]{-8});
    rules[10]=new Rule(-7, new int[]{-8,11,12});
    rules[11]=new Rule(-9, new int[]{13});
    rules[12]=new Rule(-9, new int[]{14});
    rules[13]=new Rule(-9, new int[]{15});
    rules[14]=new Rule(-9, new int[]{16});
    rules[15]=new Rule(-9, new int[]{17});
    rules[16]=new Rule(-8, new int[]{-9});
    rules[17]=new Rule(-8, new int[]{5});
    rules[18]=new Rule(-5, new int[]{5,7,-10,8,-11});
    rules[19]=new Rule(-5, new int[]{7,-10,8,-11});
    rules[20]=new Rule(-10, new int[]{-7,5,41,-10});
    rules[21]=new Rule(-10, new int[]{-7,5});
    rules[22]=new Rule(-10, new int[]{});
    rules[23]=new Rule(-12, new int[]{11,-13,12});
    rules[24]=new Rule(-11, new int[]{-12,-11});
    rules[25]=new Rule(-11, new int[]{-14});
    rules[26]=new Rule(-15, new int[]{-11,-15});
    rules[27]=new Rule(-15, new int[]{-11});
    rules[28]=new Rule(-14, new int[]{42});
    rules[29]=new Rule(-14, new int[]{-8,5,26,-16,42});
    rules[30]=new Rule(-14, new int[]{-16,42});
    rules[31]=new Rule(-14, new int[]{9,10});
    rules[32]=new Rule(-14, new int[]{9,-15,10});
    rules[33]=new Rule(-14, new int[]{4,7,-16,8,-11});
    rules[34]=new Rule(-16, new int[]{-17});
    rules[35]=new Rule(-16, new int[]{-16,29,-17});
    rules[36]=new Rule(-16, new int[]{-16,30,-17});
    rules[37]=new Rule(-16, new int[]{-16,31,-17});
    rules[38]=new Rule(-16, new int[]{-16,39,-16,40,-16});
    rules[39]=new Rule(-16, new int[]{-18,26,-16});
    rules[40]=new Rule(-16, new int[]{-18,11,12,26,-16});
    rules[41]=new Rule(-17, new int[]{-19});
    rules[42]=new Rule(-17, new int[]{-17,33,-19});
    rules[43]=new Rule(-17, new int[]{-17,34,-19});
    rules[44]=new Rule(-17, new int[]{-17,35,-19});
    rules[45]=new Rule(-17, new int[]{-17,36,-19});
    rules[46]=new Rule(-17, new int[]{-17,37,-19});
    rules[47]=new Rule(-17, new int[]{-17,38,-19});
    rules[48]=new Rule(-19, new int[]{-20});
    rules[49]=new Rule(-19, new int[]{-19,22,-20});
    rules[50]=new Rule(-19, new int[]{-19,23,-20});
    rules[51]=new Rule(-20, new int[]{-21});
    rules[52]=new Rule(-20, new int[]{-20,24,-21});
    rules[53]=new Rule(-20, new int[]{-20,25,-21});
    rules[54]=new Rule(-21, new int[]{-18});
    rules[55]=new Rule(-21, new int[]{-22});
    rules[56]=new Rule(-21, new int[]{32,-21});
    rules[57]=new Rule(-21, new int[]{23,-21});
    rules[58]=new Rule(-21, new int[]{22,-21});
    rules[59]=new Rule(-21, new int[]{28,-21});
    rules[60]=new Rule(-21, new int[]{27,-21});
    rules[61]=new Rule(-21, new int[]{-21,28});
    rules[62]=new Rule(-21, new int[]{-21,27});
    rules[63]=new Rule(-21, new int[]{7,-16,8});
    rules[64]=new Rule(-21, new int[]{7,-9,8,-21});
    rules[65]=new Rule(-21, new int[]{-13});
    rules[66]=new Rule(-18, new int[]{5});
    rules[67]=new Rule(-18, new int[]{6});
    rules[68]=new Rule(-22, new int[]{18});
    rules[69]=new Rule(-22, new int[]{19});
    rules[70]=new Rule(-22, new int[]{20});
    rules[71]=new Rule(-22, new int[]{21});
    rules[72]=new Rule(-13, new int[]{5,7,-23,8});
    rules[73]=new Rule(-23, new int[]{-24});
    rules[74]=new Rule(-23, new int[]{});
    rules[75]=new Rule(-24, new int[]{-16});
    rules[76]=new Rule(-24, new int[]{-16,41,-24});
    this.InitRules(rules);

    this.InitNonTerminals(new string[] {"", "init", "$accept", "globaldecls", 
      "classdecl", "methoddecl", "propertylist", "typename", "singletype", "singlebasetype", 
      "argslist", "contextstatement", "contextdef", "methodcall", "statement", 
      "statementlist", "expr", "expr2", "varuse", "expr3", "term", "factor", 
      "literal", "callargs", "nextcallargs", });
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // init -> globaldecls
{ Ast = new GlobalCode((DeclarationsList)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 3: // globaldecls -> classdecl, globaldecls
{ CurrentSemanticValue.obj = new DeclarationsList( LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]), (DeclarationsList)ValueStack[ValueStack.Depth-1].obj, (ClassDecl)ValueStack[ValueStack.Depth-2].obj ); }
        break;
      case 4: // globaldecls -> methoddecl, globaldecls
{ CurrentSemanticValue.obj = new DeclarationsList( LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]), (DeclarationsList)ValueStack[ValueStack.Depth-1].obj, (MethodDecl)ValueStack[ValueStack.Depth-2].obj ); }
        break;
      case 5: // globaldecls -> EOF
{ CurrentSemanticValue.obj = new DeclarationsList( new ExprPosition() ); }
        break;
      case 6: // classdecl -> CLASS, IDENTIFIER, LBRACE, propertylist, RBRACE
{ CurrentSemanticValue.obj = new ClassDecl( LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-1]), (string)ValueStack[ValueStack.Depth-4].obj, (List<VariableDecl>)ValueStack[ValueStack.Depth-2].obj ); }
        break;
      case 7: // propertylist -> typename, IDENTIFIER, SEMICOLON, propertylist
{ CurrentSemanticValue.obj = VariableDecls(ValueStack[ValueStack.Depth-1].obj, new VariableDecl(LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-3]),(ExpressionType)ValueStack[ValueStack.Depth-4].obj,(string)ValueStack[ValueStack.Depth-3].obj)); }
        break;
      case 8: // propertylist -> /* empty */
{ CurrentSemanticValue.obj = null; }
        break;
      case 9: // typename -> singletype
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 10: // typename -> singletype, LBRACKET, RBRACKET
{ CurrentSemanticValue.obj = new ExpressionListType( (ExpressionType)ValueStack[ValueStack.Depth-3].obj ); }
        break;
      case 11: // singlebasetype -> TSTRING
{ CurrentSemanticValue.obj = ExpressionType.StringType; }
        break;
      case 12: // singlebasetype -> TINT
{ CurrentSemanticValue.obj = ExpressionType.IntType; }
        break;
      case 13: // singlebasetype -> TDOUBLE
{ CurrentSemanticValue.obj = ExpressionType.DoubleType; }
        break;
      case 14: // singlebasetype -> TDATETIME
{ CurrentSemanticValue.obj = ExpressionType.DateTimeType; }
        break;
      case 15: // singlebasetype -> TBOOL
{ CurrentSemanticValue.obj = ExpressionType.BoolType; }
        break;
      case 16: // singletype -> singlebasetype
{CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj;}
        break;
      case 17: // singletype -> IDENTIFIER
{ CurrentSemanticValue.obj = new ExpressionType((string)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 18: // methoddecl -> IDENTIFIER, LPAREN, argslist, RPAREN, contextstatement
{ CurrentSemanticValue.obj = new MethodDecl( LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-2]), (string)ValueStack[ValueStack.Depth-5].obj, (List<VariableDecl>)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj ); }
        break;
      case 19: // methoddecl -> LPAREN, argslist, RPAREN, contextstatement
{ CurrentSemanticValue.obj = new MethodDecl( LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-2]), null, (List<VariableDecl>)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj ); }
        break;
      case 20: // argslist -> typename, IDENTIFIER, COMMA, argslist
{ CurrentSemanticValue.obj = VariableDecls(ValueStack[ValueStack.Depth-1].obj, new VariableDecl(LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-3]),(ExpressionType)ValueStack[ValueStack.Depth-4].obj,(string)ValueStack[ValueStack.Depth-3].obj)); }
        break;
      case 21: // argslist -> typename, IDENTIFIER
{ CurrentSemanticValue.obj = VariableDecls(null, new VariableDecl(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(ExpressionType)ValueStack[ValueStack.Depth-2].obj,(string)ValueStack[ValueStack.Depth-1].obj)); }
        break;
      case 22: // argslist -> /* empty */
{ CurrentSemanticValue.obj = null; }
        break;
      case 23: // contextdef -> LBRACKET, methodcall, RBRACKET
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-2].obj; }
        break;
      case 24: // contextstatement -> contextdef, contextstatement
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; AddDataContext(ref CurrentSemanticValue.obj,(MethodCall)ValueStack[ValueStack.Depth-2].obj); }
        break;
      case 25: // contextstatement -> statement
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 26: // statementlist -> contextstatement, statementlist
{ CurrentSemanticValue.obj = ExpressionList(ValueStack[ValueStack.Depth-1].obj, (Expression)ValueStack[ValueStack.Depth-2].obj); }
        break;
      case 27: // statementlist -> contextstatement
{ CurrentSemanticValue.obj = ExpressionList(null, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 28: // statement -> SEMICOLON
{ CurrentSemanticValue.obj = null; /*empty statement*/ }
        break;
      case 29: // statement -> singletype, IDENTIFIER, OP_ASSIGN, expr, SEMICOLON
{ CurrentSemanticValue.obj = new VariableDecl(LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-1]),(ExpressionType)ValueStack[ValueStack.Depth-5].obj,(string)ValueStack[ValueStack.Depth-4].obj,(Expression)ValueStack[ValueStack.Depth-2].obj);/* declare and initialize variable */ }
        break;
      case 30: // statement -> expr, SEMICOLON
{ CurrentSemanticValue.obj = new Statement(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-2].obj); }
        break;
      case 31: // statement -> LBRACE, RBRACE
{ CurrentSemanticValue.obj = null; }
        break;
      case 32: // statement -> LBRACE, statementlist, RBRACE
{ CurrentSemanticValue.obj = new CodeBlock( LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (List<Expression>)ValueStack[ValueStack.Depth-2].obj ); }
        break;
      case 33: // statement -> FOREACH, LPAREN, expr, RPAREN, contextstatement
{ CurrentSemanticValue.obj = new Foreach(LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj,(Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 34: // expr -> expr2
{CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj;}
        break;
      case 35: // expr -> expr, OP_LOGIC_OR, expr2
{CurrentSemanticValue.obj = new LogicalOrExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 36: // expr -> expr, OP_LOGIC_AND, expr2
{CurrentSemanticValue.obj = new LogicalAndExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 37: // expr -> expr, OP_LOGIC_XOR, expr2
{CurrentSemanticValue.obj = new LogicalXorExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 38: // expr -> expr, OP_QUESTION, expr, OP_COLON, expr
{CurrentSemanticValue.obj = new TernaryCondExpression(LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-5].obj,(Expression)ValueStack[ValueStack.Depth-3].obj,(Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 39: // expr -> varuse, OP_ASSIGN, expr
{CurrentSemanticValue.obj = new BinaryAssignExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 40: // expr -> varuse, LBRACKET, RBRACKET, OP_ASSIGN, expr
{ CurrentSemanticValue.obj = new AddElementExpression(LocationStack[LocationStack.Depth-5].Merge(LocationStack[LocationStack.Depth-1]),(VariableUse)ValueStack[ValueStack.Depth-5].obj, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 41: // expr2 -> expr3
{CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj;}
        break;
      case 42: // expr2 -> expr2, OP_EQ, expr3
{CurrentSemanticValue.obj = new EqExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 43: // expr2 -> expr2, OP_NOTEQ, expr3
{CurrentSemanticValue.obj = new NotEqExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 44: // expr2 -> expr2, OP_LESS, expr3
{CurrentSemanticValue.obj = new BinaryLessExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 45: // expr2 -> expr2, OP_GREATER, expr3
{CurrentSemanticValue.obj = new BinaryGreaterExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 46: // expr2 -> expr2, OP_LESSEQ, expr3
{CurrentSemanticValue.obj = new BinaryLessEqExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 47: // expr2 -> expr2, OP_GREATEREQ, expr3
{CurrentSemanticValue.obj = new BinaryGreaterEqExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj);}
        break;
      case 48: // expr3 -> term
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 49: // expr3 -> expr3, OP_ADD, term
{ CurrentSemanticValue.obj = new BinaryAddExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 50: // expr3 -> expr3, OP_SUB, term
{ CurrentSemanticValue.obj = new BinarySubExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 51: // term -> factor
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 52: // term -> term, OP_MUL, factor
{ CurrentSemanticValue.obj = new BinaryMulExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 53: // term -> term, OP_DIV, factor
{ CurrentSemanticValue.obj = new BinaryDivExpression(LocationStack[LocationStack.Depth-3].Merge(LocationStack[LocationStack.Depth-1]), (Expression)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 54: // factor -> varuse
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 55: // factor -> literal
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 56: // factor -> OP_LOGIC_NOT, factor
{CurrentSemanticValue.obj = new LogicalNotExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 57: // factor -> OP_SUB, factor
{  CurrentSemanticValue.obj = new UnaryMinusExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 58: // factor -> OP_ADD, factor
{  CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 59: // factor -> OP_SUB1, factor
{  CurrentSemanticValue.obj = new BinaryAddExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-1].obj, new IntLiteral(LocationStack[LocationStack.Depth-2],-1)); }
        break;
      case 60: // factor -> OP_ADD1, factor
{  CurrentSemanticValue.obj = new BinaryAddExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-1].obj, new IntLiteral(LocationStack[LocationStack.Depth-2],+1)); }
        break;
      case 61: // factor -> factor, OP_SUB1
{  CurrentSemanticValue.obj = new BinaryAddExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-2].obj, new IntLiteral(LocationStack[LocationStack.Depth-2],-1)); }
        break;
      case 62: // factor -> factor, OP_ADD1
{  CurrentSemanticValue.obj = new BinaryAddExpression(LocationStack[LocationStack.Depth-2].Merge(LocationStack[LocationStack.Depth-1]),(Expression)ValueStack[ValueStack.Depth-2].obj, new IntLiteral(LocationStack[LocationStack.Depth-2],+1)); }
        break;
      case 63: // factor -> LPAREN, expr, RPAREN
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-2].obj; }
        break;
      case 64: // factor -> LPAREN, singlebasetype, RPAREN, factor
{ CurrentSemanticValue.obj = new TypeCastExpression( LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-1]), (ExpressionType)ValueStack[ValueStack.Depth-3].obj, (Expression)ValueStack[ValueStack.Depth-1].obj ); }
        break;
      case 65: // factor -> methodcall
{ CurrentSemanticValue.obj = ValueStack[ValueStack.Depth-1].obj; }
        break;
      case 66: // varuse -> IDENTIFIER
{ CurrentSemanticValue.obj = new VariableUse( LocationStack[LocationStack.Depth-1], (string)ValueStack[ValueStack.Depth-1].obj ); }
        break;
      case 67: // varuse -> DOTTEDIDENTIFIER
{ CurrentSemanticValue.obj = new VariableUse( LocationStack[LocationStack.Depth-1], (string)ValueStack[ValueStack.Depth-1].obj ); }
        break;
      case 68: // literal -> STRINGVAL
{ CurrentSemanticValue.obj = new StringLiteral(LocationStack[LocationStack.Depth-1], (string)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 69: // literal -> INTEGERVAL
{ CurrentSemanticValue.obj = new IntLiteral(LocationStack[LocationStack.Depth-1], (int)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 70: // literal -> DOUBLEVAL
{ CurrentSemanticValue.obj = new DoubleLiteral(LocationStack[LocationStack.Depth-1], (double)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 71: // literal -> BOOLVAL
{ CurrentSemanticValue.obj = new BoolLiteral(LocationStack[LocationStack.Depth-1], (bool)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 72: // methodcall -> IDENTIFIER, LPAREN, callargs, RPAREN
{ CurrentSemanticValue.obj = new MethodCall( LocationStack[LocationStack.Depth-4].Merge(LocationStack[LocationStack.Depth-1]), (string)ValueStack[ValueStack.Depth-4].obj, (List<Expression>)ValueStack[ValueStack.Depth-2].obj ); }
        break;
      case 73: // callargs -> nextcallargs
{ CurrentSemanticValue.obj = ExpressionList(ValueStack[ValueStack.Depth-1].obj,null); }
        break;
      case 74: // callargs -> /* empty */
{ CurrentSemanticValue.obj = ExpressionList(null,null); }
        break;
      case 75: // nextcallargs -> expr
{ CurrentSemanticValue.obj = ExpressionList(null,(Expression)ValueStack[ValueStack.Depth-1].obj); }
        break;
      case 76: // nextcallargs -> expr, COMMA, nextcallargs
{ CurrentSemanticValue.obj = ExpressionList(ValueStack[ValueStack.Depth-1].obj,(Expression)ValueStack[ValueStack.Depth-3].obj); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }


	/* creates new list of variables declaration from old List<VariableDecl> and new VariableDecl */
	private List<VariableDecl> VariableDecls( object decls, VariableDecl vardecl )
	{
		var newdecls = (decls!=null)?(new List<VariableDecl>( (List<VariableDecl>)decls )):(new List<VariableDecl>());
		if(vardecl!=null)newdecls.Insert(0,vardecl);		
		return newdecls;
	}
	
	/* creates new list of expressions from old List<Expression> and new Expression */
	private List<Expression> ExpressionList( object exprs, Expression expr )
	{
		var newexprs = (exprs!=null)?(new List<Expression>( (List<Expression>)exprs )):(new List<Expression>());
		
		if(expr!=null)
		{
			CodeBlock exprbl;
			if ( (exprbl = expr as CodeBlock) != null )
			{	// reduces the tree (empty CodeBlock or CodeBlock with only one expression is reduced)
				if (exprbl.Statements.Count > 0)
				{
					newexprs.Insert( 0, (exprbl.Statements.Count==1 && exprbl.DataContexts.Count == 0)?exprbl.Statements[0]:exprbl );
				}
			}
			else
				newexprs.Insert( 0, expr );
		}
		return newexprs;
	}
	
	private void AddDataContext( ref object statement, MethodCall contextcreate )
	{
		if (statement == null || contextcreate == null)	return;
		Expression expr = statement as Expression;
		CodeBlock exprbl = statement as CodeBlock;
		
		if ( expr == null )	return;
		if ( exprbl == null )	statement = exprbl = new CodeBlock( expr.Position, new List<Expression>(){ expr } );
		
		exprbl.DataContexts.AddFirst(contextcreate);
	}

	/* initialization of the parser object */
    public Parser(Scanner scanner)
     :base(scanner)
    {
    
    }
    
    /* The result of the Parse() operation. */
    public GlobalCode Ast { get; private set; }

}
}
