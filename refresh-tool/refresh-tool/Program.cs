using System;

namespace refresh_tool
{
	class Program
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			Console.WriteLine("Rewriting... (C:/stepmania-modified/game/Themes/DDRextreme_beware/metrics.ini)");
			System.IO.File.WriteAllText(@"C:/stepmania-modified/game/Themes/DDRextreme_beware/metrics.ini", @"[Common]
ColorP1=#1FEFB6
ColorP2=#FFBD18
CourseDifficultiesToShow=regular,difficult
DifficultiesToShow=beginner,easy,medium,hard,challenge
WindowTitle=Dance Dance Revolution Extreme CORRUPTED
InitialScreen=ScreenWarning

[ScreenSystemLayer]
CreditsNoCard=1"+'"'+"home"+'"'+@" mode, always show credits related message
CreditsP1X="+rnd.Next(1, 641)+@"
CreditsP1Y="+rnd.Next(1, 481)+@"
CreditsP2X="+rnd.Next(1, 641)+@"
CreditsP2Y="+rnd.Next(1, 481)+@"

[ScreenLogo]
Fallback=ScreenAttract
LogoOnCommand=diffusealpha,0
NextScreen=ScreenHowToPlay

[ScreenTitleMenu]
LogoHomeOnCommand=diffusealpha,0
LogoOnCommand=diffusealpha,0
SongsOnCommand=hidden,1
VersionOnCommand=hidden,1
HelpOnCommand=hidden,1

[ScreenWithMenuElements]
HeaderX="+rnd.Next(1, 641)+@"
HeaderY="+rnd.Next(1, 481)+@"
HeaderOnCommand=draworder,95;addx,526;cropright,1;sleep,0.65;linear,0.4;addx,-526;cropright,0
HeaderOffCommand=sleep,0.05;linear,0.4;addx,526;cropright,1
FooterX="+rnd.Next(1, 641)+@"
FooterY="+rnd.Next(1, 481)+@"
FooterOnCommand=
FooterOffCommand=
StyleIconX="+rnd.Next(1, 641)+@"
StyleIconY="+rnd.Next(1, 481)+@"
StyleIconOnCommand=draworder,95;diffusealpha,0;sleep,1.016;diffusealpha,1
StyleIconOffCommand=diffusealpha,0
TimerX="+rnd.Next(1, 641)+@"
TimerY="+rnd.Next(1, 481)+@"
TimerOnCommand=draworder,95
TimerOffCommand=

[MenuTimer]
WarningStart="+rnd.Next(1, 99)+@"
WarningBeepStart="+rnd.Next(1, 99)+@"
OnCommand=stoptweening;shadowlength,0;zoomx,1
WarningCommand6=stoptweening;sleep,0.8;linear,0.2;zoomx,0
WarningCommand5=stoptweening;zoomx,0;linear,0.2;zoomx,1;sleep,0.6;linear,0.2;zoomx,0
WarningCommand4=stoptweening;zoomx,0;linear,0.2;zoomx,1;sleep,0.6;linear,0.2;zoomx,0
WarningCommand3=stoptweening;zoomx,0;linear,0.2;zoomx,1;sleep,0.6;linear,0.2;zoomx,0
WarningCommand2=stoptweening;zoomx,0;linear,0.2;zoomx,1;sleep,0.6;linear,0.2;zoomx,0
WarningCommand1=stoptweening;zoomx,0;linear,0.2;zoomx,1;sleep,0.6;linear,0.2;zoomx,0
WarningCommand0=stoptweening;linear,0.2;zoomx,1;cropbottom,1;addy,30;linear,0.2;addy,-30;

[ScreenCaution]
NextScreen=ScreenBranchSelectStyle

[ScreenBranchSelectStyle]
Class=ScreenBranch
Choices=1,2,3
Condition1=IsPlayerEnabled(1) and IsHumanPlayer(1) and IsPlayerEnabled(2) and IsHumanPlayer(2)
Condition2=IsPlayerEnabled(2) and IsHumanPlayer(2)
Condition3=true
NextScreen1=screen,ScreenSelectStyle
NextScreen2=screen,ScreenSelectStyle2
NextScreen3=screen,ScreenSelectStyle


[ScreenSelectStyle]
Fallback=ScreenWithMenuElements
Class=ScreenSelectMaster
ChoiceNames=1,2,3
DefaultChoice=1
Choice1=Style,single;name,single
Choice2=Style,versus;name,versus
Choice3=Style,double;name,double
NumIconParts=7
NumCursorParts=0
NumPreviewParts=0
NumChoices=3
NumChoicesOnPage1=3
NumCodes=0
ShowScroller=0
SharedPreviewAndCursor=1
OptionOrderUp=
OptionOrderDown=
OptionOrderLeft=
OptionOrderRight=
OptionOrderAuto=
ExtraSleepAfterTweenOffSeconds=-1
TimerSeconds="+rnd.Next(1, 100)+@"
StyleIcon=1
MemoryCardIcons=1
NextScreen1=ScreenSelectMaster
NextScreen2=ScreenSelectMasterVersus
NextScreen3=ScreenSelectMasterDouble
PrevScreen=ScreenTitleMenu
PremiumX="+rnd.Next(1, 641)+@"
PremiumY="+rnd.Next(1, 481)+@"
PremiumOnCommand=croptop,1;sleep,0.683;linear,0.217;croptop,0;decelerate,0.1;addy,-10;accelerate,0.1;addy,10
PremiumOffCommand=decelerate,0.1;addy,-10;accelerate,0.1;addy,10;linear,0.217;croptop,1
ExplanationPage1X="+rnd.Next(1, 641)+@"
ExplanationPage1Y="+rnd.Next(1, 481)+@"
ExplanationPage1OnCommand=draworder,95;cropleft,1;sleep,0.317;cropleft,0.774;addx,-260;sleep,0.183;linear,0.2;addx,260;cropleft,0
ExplanationPage1OffCommand=sleep,0.383;linear,0.2;addx,-260;cropleft,0.774;sleep,0.183;cropleft,1
MorePage1Y="+rnd.Next(1, 641)+@"
MorePage1X="+rnd.Next(1, 481)+@"
MorePage1OnCommand=
MorePage1OffCommand=
MorePage2OffCommand=

IconPart1ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart1ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart1ChoicesingleOnCommand=croptop,1;sleep,0.683;linear,0.217;croptop,0;decelerate,0.1;addy,-10;accelerate,0.1;addy,10
IconPart1ChoicesingleOffCommand=decelerate,0.1;addy,-10;accelerate,0.1;addy,10;linear,0.217;croptop,1
IconPart1ChoicesingleEnabledCommand=diffuse,1,1,1,1
IconPart1ChoicesingleDisabledCommand=diffuse,0.2,0.2,0.2,1
IconPart1ChoicesingleGainFocusCommand=
IconPart1ChoicesingleLoseFocusCommand=
IconPart1ChoicesingleOffFocusedCommand=
IconPart1ChoicesingleOffUnfocusedCommand=

IconPart1ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart1ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart1ChoiceversusOnCommand=croptop,1;sleep,0.683;linear,0.217;croptop,0;decelerate,0.1;addy,-10;accelerate,0.1;addy,10
IconPart1ChoiceversusOffCommand=decelerate,0.1;addy,-10;accelerate,0.1;addy,10;linear,0.217;croptop,1
IconPart1ChoiceversusEnabledCommand=diffuse,1,1,1,1
IconPart1ChoiceversusDisabledCommand=diffuse,0.2,0.2,0.2,1
IconPart1ChoiceversusGainFocusCommand=
IconPart1ChoiceversusLoseFocusCommand=
IconPart1ChoiceversusOffFocusedCommand=
IconPart1ChoiceversusOffUnfocusedCommand=

IconPart1ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart1ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart1ChoicedoubleOnCommand=croptop,1;sleep,0.683;linear,0.217;croptop,0;decelerate,0.1;addy,-10;accelerate,0.1;addy,10
IconPart1ChoicedoubleOffCommand=decelerate,0.1;addy,-10;accelerate,0.1;addy,10;linear,0.217;croptop,1
IconPart1ChoicedoubleEnabledCommand=diffuse,1,1,1,1
IconPart1ChoicedoubleDisabledCommand=diffuse,0.2,0.2,0.2,1
IconPart1ChoicedoubleGainFocusCommand=
IconPart1ChoicedoubleLoseFocusCommand=
IconPart1ChoicedoubleOffFocusedCommand=
IconPart1ChoicedoubleOffUnfocusedCommand=

IconPart2ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart2ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart2ChoicesingleOnCommand=addy,999;sleep,1.1;addy,-999
IconPart2ChoicesingleOffCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicesingleEnabledCommand=
IconPart2ChoicesingleDisabledCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicesingleGainFocusCommand=diffuseshift;blend,add;effectcolor1,0,0,0,1;effectcolor2,0.37,0.37,0.37,1;effectperiod,0.480
IconPart2ChoicesingleLoseFocusCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicesingleOffFocusedCommand=
IconPart2ChoicesingleOffUnfocusedCommand=

IconPart2ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart2ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart2ChoiceversusOnCommand=addy,999;sleep,1.1;addy,-999
IconPart2ChoiceversusOffCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoiceversusEnabledCommand=
IconPart2ChoiceversusDisabledCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoiceversusGainFocusCommand=diffuseshift;blend,add;effectcolor1,0,0,0,1;effectcolor2,0.37,0.37,0.37,1;effectperiod,0.480
IconPart2ChoiceversusLoseFocusCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoiceversusOffFocusedCommand=
IconPart2ChoiceversusOffUnfocusedCommand=

IconPart2ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart2ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart2ChoicedoubleOnCommand=addy,999;sleep,1.1;addy,-999
IconPart2ChoicedoubleOffCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicedoubleEnabledCommand=
IconPart2ChoicedoubleDisabledCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicedoubleGainFocusCommand=diffuseshift;blend,add;effectcolor1,0,0,0,1;effectcolor2,0.37,0.37,0.37,1;effectperiod,0.480
IconPart2ChoicedoubleLoseFocusCommand=stopeffect;diffuse,0,0,0,0
IconPart2ChoicedoubleOffFocusedCommand=
IconPart2ChoicedoubleOffUnfocusedCommand=


IconPart3ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart3ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart3ChoicesingleOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.1;diffusealpha,0;linear,0.1;diffusealpha,1;zoomy,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart3ChoicesingleOffCommand=zoomy,1;sleep,0.133;zoomy,1;linear,0.066;zoomy,1.2;sleep,0;linear,0.066;zoomy,1;diffusealpha,1;linear,0.132;diffusealpha,0
IconPart3ChoicesingleEnabledCommand=
IconPart3ChoicesingleDisabledCommand=
IconPart3ChoicesingleGainFocusCommand=hidden,0
IconPart3ChoicesingleLoseFocusCommand=hidden,1
IconPart3ChoicesingleOffFocusedCommand=
IconPart3ChoicesingleOffUnfocusedCommand=

IconPart3ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart3ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart3ChoiceversusOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.1;diffusealpha,0;linear,0.1;diffusealpha,1;zoomy,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart3ChoiceversusOffCommand=zoomy,1;sleep,0.133;zoomy,1;linear,0.066;zoomy,1.2;sleep,0;linear,0.066;zoomy,1;diffusealpha,1;linear,0.132;diffusealpha,0
IconPart3ChoiceversusEnabledCommand=
IconPart3ChoiceversusDisabledCommand=
IconPart3ChoiceversusGainFocusCommand=hidden,0
IconPart3ChoiceversusLoseFocusCommand=hidden,1
IconPart3ChoiceversusOffFocusedCommand=
IconPart3ChoiceversusOffUnfocusedCommand=

IconPart3ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart3ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart3ChoicedoubleOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.1;diffusealpha,0;linear,0.1;diffusealpha,1;zoomy,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart3ChoicedoubleOffCommand=zoomy,1;sleep,0.133;zoomy,1;linear,0.066;zoomy,1.2;sleep,0;linear,0.066;zoomy,1;diffusealpha,1;linear,0.132;diffusealpha,0
IconPart3ChoicedoubleEnabledCommand=
IconPart3ChoicedoubleDisabledCommand=
IconPart3ChoicedoubleGainFocusCommand=hidden,0
IconPart3ChoicedoubleLoseFocusCommand=hidden,1
IconPart3ChoicedoubleOffFocusedCommand=
IconPart3ChoicedoubleOffUnfocusedCommand=


IconPart4ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart4ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart4ChoicesingleOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.333;linear,0.117;diffusealpha,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart4ChoicesingleOffCommand=zoomy,1;sleep,0;accelerate,0.066;zoomy,1.2;decelerate,0.066;zoomy,1;linear,0;diffusealpha,0
IconPart4ChoicesingleEnabledCommand=
IconPart4ChoicesingleDisabledCommand=
IconPart4ChoicesingleGainFocusCommand=hidden,0
IconPart4ChoicesingleLoseFocusCommand=hidden,1
IconPart4ChoicesingleOffFocusedCommand=
IconPart4ChoicesingleOffUnfocusedCommand=

IconPart4ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart4ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart4ChoiceversusOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.333;linear,0.117;diffusealpha,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart4ChoiceversusOffCommand=zoomy,1;sleep,0;accelerate,0.066;zoomy,1.2;decelerate,0.066;zoomy,1;linear,0;diffusealpha,0
IconPart4ChoiceversusEnabledCommand=
IconPart4ChoiceversusDisabledCommand=
IconPart4ChoiceversusGainFocusCommand=hidden,0
IconPart4ChoiceversusLoseFocusCommand=hidden,1
IconPart4ChoiceversusOffFocusedCommand=
IconPart4ChoiceversusOffUnfocusedCommand=

IconPart4ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart4ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart4ChoicedoubleOnCommand=diffuse,1,1,0.6,1;vertalign,bottom;diffusealpha,0;sleep,1.333;linear,0.117;diffusealpha,1;decelerate,0.066;zoomy,1.2;accelerate,0.066;zoomy,1
IconPart4ChoicedoubleOffCommand=zoomy,1;sleep,0;accelerate,0.066;zoomy,1.2;decelerate,0.066;zoomy,1;linear,0;diffusealpha,0
IconPart4ChoicedoubleEnabledCommand=
IconPart4ChoicedoubleDisabledCommand=
IconPart4ChoicedoubleGainFocusCommand=hidden,0
IconPart4ChoicedoubleLoseFocusCommand=hidden,1
IconPart4ChoicedoubleOffFocusedCommand=
IconPart4ChoicedoubleOffUnfocusedCommand=


IconPart5ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart5ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart5ChoicesingleOnCommand=vertalign,top;addy,-999;sleep,0.473;addy,999;addy,-76;linear,0.160;addy,76;decelerate,0.033;zoomy,0.95;accelerate,0.033;zoomy,1;decelerate,0.033;zoomy,1.05;accelerate,0.033;zoomy,1;sleep,0.8;diffusealpha,0
IconPart5ChoicesingleOffCommand=diffusealpha,1;linear,0.160;addy,-76;sleep,0;addy,-999
IconPart5ChoicesingleEnabledCommand=
IconPart5ChoicesingleDisabledCommand=
IconPart5ChoicesingleGainFocusCommand=
IconPart5ChoicesingleLoseFocusCommand=
IconPart5ChoicesingleOffFocusedCommand=
IconPart5ChoicesingleOffUnfocusedCommand=

IconPart5ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart5ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart5ChoiceversusOnCommand=vertalign,top;addy,-999;sleep,1.55;addy,999;diffuseshift;effectperiod,0.5;effectcolor1,1,1,1,1;effectcolor2,0.5,0.5,0.5,1
IconPart5ChoiceversusOffCommand=hidden,1
IconPart5ChoiceversusEnabledCommand=
IconPart5ChoiceversusDisabledCommand=
IconPart5ChoiceversusGainFocusCommand=
IconPart5ChoiceversusLoseFocusCommand=
IconPart5ChoiceversusOffFocusedCommand=
IconPart5ChoiceversusOffUnfocusedCommand=

IconPart5ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart5ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart5ChoicedoubleOnCommand=
IconPart5ChoicedoubleOffCommand=
IconPart5ChoicedoubleEnabledCommand=
IconPart5ChoicedoubleDisabledCommand=
IconPart5ChoicedoubleGainFocusCommand=
IconPart5ChoicedoubleLoseFocusCommand=
IconPart5ChoicedoubleOffFocusedCommand=
IconPart5ChoicedoubleOffUnfocusedCommand=


IconPart6ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart6ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart6ChoicesingleOnCommand=zoomy,0;sleep,0.3;linear,0.2;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1
IconPart6ChoicesingleOffCommand=sleep,0.2;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;linear,0.2;zoomy,0
IconPart6ChoicesingleEnabledCommand=
IconPart6ChoicesingleDisabledCommand=
IconPart6ChoicesingleGainFocusCommand=hidden,0
IconPart6ChoicesingleLoseFocusCommand=hidden,1
IconPart6ChoicesingleOffFocusedCommand=
IconPart6ChoicesingleOffUnfocusedCommand=

IconPart6ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart6ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart6ChoiceversusOnCommand=zoomy,0;sleep,0.3;linear,0.2;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1
IconPart6ChoiceversusOffCommand=sleep,0.2;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;linear,0.2;zoomy,0
IconPart6ChoiceversusEnabledCommand=
IconPart6ChoiceversusDisabledCommand=
IconPart6ChoiceversusGainFocusCommand=hidden,0
IconPart6ChoiceversusLoseFocusCommand=hidden,1
IconPart6ChoiceversusOffFocusedCommand=
IconPart6ChoiceversusOffUnfocusedCommand=

IconPart6ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart6ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart6ChoicedoubleOnCommand=zoomy,0;sleep,0.3;linear,0.2;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1
IconPart6ChoicedoubleOffCommand=sleep,0.2;decelerate,0.05;zoomy,0.98;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.05;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,0.9;accelerate,0.05;zoomy,1;decelerate,0.05;zoomy,1.1;accelerate,0.05;zoomy,1;linear,0.2;zoomy,0
IconPart6ChoicedoubleEnabledCommand=
IconPart6ChoicedoubleDisabledCommand=
IconPart6ChoicedoubleGainFocusCommand=hidden,0
IconPart6ChoicedoubleLoseFocusCommand=hidden,1
IconPart6ChoicedoubleOffFocusedCommand=
IconPart6ChoicedoubleOffUnfocusedCommand=

IconPart7ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart7ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart7ChoicesingleOnCommand=addy,999;sleep,1.1;addy,-999;diffuseblink;effectperiod,0.53
IconPart7ChoicesingleOffCommand=hidden,1
IconPart7ChoicesingleEnabledCommand=
IconPart7ChoicesingleDisabledCommand=
IconPart7ChoicesingleGainFocusCommand=
IconPart7ChoicesingleLoseFocusCommand=
IconPart7ChoicesingleOffFocusedCommand=
IconPart7ChoicesingleOffUnfocusedCommand=

IconPart7ChoiceversusX="+rnd.Next(1, 641)+@"
IconPart7ChoiceversusY="+rnd.Next(1, 641)+@"
IconPart7ChoiceversusOnCommand=addy,999;sleep,1.1;addy,-999;diffuseblink;effectperiod,0.53
IconPart7ChoiceversusOffCommand=hidden,1
IconPart7ChoiceversusEnabledCommand=hidden,0
IconPart7ChoiceversusDisabledCommand=hidden,1
IconPart7ChoiceversusGainFocusCommand=
IconPart7ChoiceversusLoseFocusCommand=
IconPart7ChoiceversusOffFocusedCommand=
IconPart7ChoiceversusOffUnfocusedCommand=

IconPart7ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart7ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart7ChoicedoubleOnCommand=
IconPart7ChoicedoubleOffCommand=
IconPart7ChoicedoubleEnabledCommand=
IconPart7ChoicedoubleDisabledCommand=
IconPart7ChoicedoubleGainFocusCommand=
IconPart7ChoicedoubleLoseFocusCommand=
IconPart7ChoicedoubleOffFocusedCommand=
IconPart7ChoicedoubleOffUnfocusedCommand=


[ScreenSelectStyle2]
Fallback=ScreenSelectStyle
Class=ScreenSelectMaster
IconPart4ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart4ChoicesingleY="+rnd.Next(1, 641)+@"
IconPart4ChoicedoubleX="+rnd.Next(1, 641)+@"
IconPart4ChoicedoubleY="+rnd.Next(1, 641)+@"
IconPart7ChoicesingleX="+rnd.Next(1, 641)+@"
IconPart7ChoiceversusX="+rnd.Next(1, 641)+@"

[ScreenSelectMaster]
Class=ScreenSelectMaster
Fallback=ScreenWithMenuElements
PrevScreen=ScreenTitleMenu
NumCodes=0
TimerSeconds="+rnd.Next(1, 100)+@"
NumChoicesOnPage1=4
NumIconParts=3
NumPreviewParts=2
NumCursorParts=3
NumChoices=6
PreSwitchPageSeconds=0.233
PostSwitchPageSeconds=0.233
DefaultChoice=1
HelpText=
SharedPreviewAndCursor=0
ShowScroller=0
ExtraSleepAfterTweenOffSeconds=-1
ChoiceNames=1,2,3,4,5,6
Choice1=PlayMode,regular;Difficulty,beginner;name,BEGINNER
Choice2=PlayMode,regular;Difficulty,easy;name,LIGHT
Choice3=PlayMode,regular;Difficulty,medium;name,STANDARD
Choice4=PlayMode,regular;Difficulty,hard;name,HEAVY
Choice5=PlayMode,nonstop;name,NONSTOP
Choice6=PlayMode,oni;name,ONI
NextScreen1=ScreenInstructions
NextScreen2=ScreenInstructions
NextScreen3=ScreenInstructions
NextScreen4=ScreenInstructions
NextScreen5=ScreenInstructions
NextScreen6=ScreenInstructions
OptionOrderAuto=
OptionOrderUp=
OptionOrderDown=
OptionOrderLeft=
OptionOrderRight=
OptionOrderAutoP1=
OptionOrderUpP1=
OptionOrderDownP1=
OptionOrderLeftP1=6:5,5:4,4:3,3:2,2:1
OptionOrderRightP1=1:2,2:3,3:4,4:5,5:6
OptionOrderAutoP2=
OptionOrderUpP2=
OptionOrderDownP2=
OptionOrderLeftP2=6:5,5:4,4:3,3:2,2:1
OptionOrderRightP2=1:2,2:3,3:4,4:5,5:6
ExplanationPage1X="+rnd.Next(1, 641)+@"
ExplanationPage1Y="+rnd.Next(1, 641)+@"
ExplanationPage1OnCommand=
ExplanationPage1OffCommand=
ExplanationPage1SwitchToPage2Command=
ExplanationPage1SwitchToPage1Command=
ExplanationPage2X=
ExplanationPage2Y=
ExplanationPage2OnCommand=
ExplanationPage2OffCommand=
ExplanationPage2SwitchToPage2Command=
ExplanationPage2SwitchToPage1Command=
MorePage1X="+rnd.Next(1, 641)+@"
MorePage1Y="+rnd.Next(1, 481)+@"
MorePage1OnCommand=draworder,10;cropbottom,1;addy,32;sleep,0.533;linear,0.466;cropbottom,0;addy,-32
MorePage1OffCommand=linear,0.467;addy,32;cropbottom,1
MorePage1SwitchToPage2Command=linear,0.233;addx,160
MorePage1SwitchToPage1Command=sleep,0.233;linear,0.233;addx,-160
MorePage2X=
MorePage2Y=
MorePage2OnCommand=
MorePage2OffCommand=
MorePage2SwitchToPage2Command=
MorePage2SwitchToPage1Command=
CursorPart1P1ChangeCommand=
CursorPart1P1ChooseCommand=
CursorPart1P1PreSwitchPageCommand=
CursorPart1P1PostSwitchPageCommand=
CursorPart1P1OffCommand=
CursorPart1P1OffsetXFromIcon=0
CursorPart1P1OffsetYFromIcon=0
CursorPart1P1OnCommand=
CursorPart1P2ChooseCommand=
CursorPart1P2ChangeCommand=
CursorPart1P2PreSwitchPageCommand=
CursorPart1P2PostSwitchPageCommand=
CursorPart1P2OffCommand=sleep,0.716;cropbottom,1
CursorPart1P2OffsetXFromIcon=0
CursorPart1P2OffsetYFromIcon=0
CursorPart1P2OnCommand=draworder,3;diffusealpha,0;sleep,0.55;diffusealpha,1
CursorPart2P1ChooseCommand=
CursorPart2P1ChangeCommand=
CursorPart2P1PreSwitchPageCommand=
CursorPart2P1PostSwitchPageCommand=
CursorPart2P1OnCommand=draworder,3;draworder,3;diffusealpha,0;sleep,0.55;diffusealpha,1
CursorPart2P1OffCommand=sleep,0.716;cropbottom,1
CursorPart2P1OffsetXFromIcon=0
CursorPart2P1OffsetYFromIcon=0
CursorPart2P2ChooseCommand=
CursorPart2P2ChangeCommand=
CursorPart2P2PreSwitchPageCommand=
CursorPart2P2PostSwitchPageCommand=
CursorPart2P2OffCommand=sleep,0.716;cropbottom,1
CursorPart2P2OffsetXFromIcon=0
CursorPart2P2OffsetYFromIcon=0
CursorPart2P2OnCommand=draworder,4;cropleft,1;sleep,0.55;cropleft,0.5
CursorPart3P1ChangeCommand=
CursorPart3P1ChooseCommand=x,244;y,324;addy,68;diffusealpha,1;cropbottom,1;linear,0.083;addy,-68;cropbottom,0;decelerate,0.083;addy,-20;accelerate,0.083;addy,20;sleep,0.75
CursorPart3P1PreSwitchPageCommand=
CursorPart3P1PostSwitchPageCommand=
CursorPart3P1OffCommand=sleep,0.233;linear,0.1;cropright,1
CursorPart3P1OffsetXFromIcon=0
CursorPart3P1OffsetYFromIcon=0
CursorPart3P1OnCommand=draworder,10;diffusealpha,0
CursorPart3P2ChangeCommand=
CursorPart3P2ChooseCommand=x,396;y,324;addy,68;diffusealpha,1;cropbottom,1;linear,0.083;addy,-68;cropbottom,0;decelerate,0.083;addy,-20;accelerate,0.083;addy,20;sleep,0.75
CursorPart3P2PreSwitchPageCommand=
CursorPart3P2PostSwitchPageCommand=
CursorPart3P2OffCommand=sleep,0.233;linear,0.1;cropleft,1
CursorPart3P2OffsetXFromIcon=0
CursorPart3P2OffsetYFromIcon=0
CursorPart3P2OnCommand=draworder,10;diffusealpha,0
IconPart1ChoiceBEGINNERX="+rnd.Next(1, 641)+@"
IconPart1ChoiceBEGINNERY="+rnd.Next(1, 641)+@"
IconPart1ChoiceBEGINNEROnCommand=
IconPart1ChoiceBEGINNEROffCommand=
IconPart1ChoiceBEGINNEROffFocusedCommand=
IconPart1ChoiceBEGINNEROffUnfocusedCommand=
IconPart1ChoiceBEGINNEREnabledCommand=
IconPart1ChoiceBEGINNERGainFocusCommand=
IconPart1ChoiceBEGINNERLoseFocusCommand=
IconPart1ChoiceBEGINNERSwitchToPage1Command=
IconPart1ChoiceBEGINNERSwitchToPage2Command=
IconPart1ChoiceLIGHTX="+rnd.Next(1, 641)+@"
IconPart1ChoiceLIGHTY="+rnd.Next(1, 641)+@"
IconPart1ChoiceLIGHTOnCommand=
IconPart1ChoiceLIGHTOffCommand=
IconPart1ChoiceLIGHTOffFocusedCommand=
IconPart1ChoiceLIGHTOffUnfocusedCommand=
IconPart1ChoiceLIGHTEnabledCommand=
IconPart1ChoiceLIGHTGainFocusCommand=
IconPart1ChoiceLIGHTLoseFocusCommand=
IconPart1ChoiceLIGHTSwitchToPage1Command=
IconPart1ChoiceLIGHTSwitchToPage2Command=
IconPart1ChoiceSTANDARDX="+rnd.Next(1, 641)+@"
IconPart1ChoiceSTANDARDY="+rnd.Next(1, 641)+@"
IconPart1ChoiceSTANDARDOnCommand=
IconPart1ChoiceSTANDARDOffCommand=
IconPart1ChoiceSTANDARDOffFocusedCommand=
IconPart1ChoiceSTANDARDOffUnfocusedCommand=
IconPart1ChoiceSTANDARDEnabledCommand=
IconPart1ChoiceSTANDARDGainFocusCommand=
IconPart1ChoiceSTANDARDLoseFocusCommand=
IconPart1ChoiceSTANDARDSwitchToPage1Command=
IconPart1ChoiceSTANDARDSwitchToPage2Command=
IconPart1ChoiceHEAVYX="+rnd.Next(1, 641)+@"
IconPart1ChoiceHEAVYY="+rnd.Next(1, 641)+@"
IconPart1ChoiceHEAVYOnCommand=
IconPart1ChoiceHEAVYOffCommand=
IconPart1ChoiceHEAVYOffFocusedCommand=
IconPart1ChoiceHEAVYOffUnfocusedCommand=
IconPart1ChoiceHEAVYEnabledCommand=
IconPart1ChoiceHEAVYGainFocusCommand=
IconPart1ChoiceHEAVYLoseFocusCommand=
IconPart1ChoiceHEAVYSwitchToPage1Command=
IconPart1ChoiceHEAVYSwitchToPage2Command=
IconPart1ChoiceNONSTOPX="+rnd.Next(1, 641)+@"
IconPart1ChoiceNONSTOPY="+rnd.Next(1, 641)+@"
IconPart1ChoiceNONSTOPOnCommand=
IconPart1ChoiceNONSTOPOffCommand=
IconPart1ChoiceNONSTOPOffFocusedCommand=
IconPart1ChoiceNONSTOPOffUnfocusedCommand=
IconPart1ChoiceNONSTOPEnabledCommand=
IconPart1ChoiceNONSTOPGainFocusCommand=
IconPart1ChoiceNONSTOPLoseFocusCommand=
IconPart1ChoiceNONSTOPSwitchToPage1Command=
IconPart1ChoiceNONSTOPSwitchToPage2Command=
IconPart1ChoiceONIX="+rnd.Next(1, 641)+@"
IconPart1ChoiceONIY="+rnd.Next(1, 641)+@"
IconPart1ChoiceONIOnCommand=
IconPart1ChoiceONIOffCommand=
IconPart1ChoiceONIOffFocusedCommand=
IconPart1ChoiceONIOffUnfocusedCommand=
IconPart1ChoiceONIEnabledCommand=
IconPart1ChoiceONIGainFocusCommand=
IconPart1ChoiceONILoseFocusCommand=
IconPart1ChoiceONISwitchToPage1Command=
IconPart1ChoiceONISwitchToPage2Command=

IconPart2ChoiceBEGINNERX=
IconPart2ChoiceBEGINNERY=
IconPart2ChoiceBEGINNEROnCommand=
IconPart2ChoiceBEGINNEROffCommand=
IconPart2ChoiceBEGINNEROffFocusedCommand=
IconPart2ChoiceBEGINNEROffUnfocusedCommand=
IconPart2ChoiceBEGINNEREnabledCommand=
IconPart2ChoiceBEGINNERGainFocusCommand=
IconPart2ChoiceBEGINNERLoseFocusCommand=
IconPart2ChoiceBEGINNERSwitchToPage1Command=
IconPart2ChoiceBEGINNERSwitchToPage2Command=
IconPart2ChoiceLIGHTX="+rnd.Next(1, 641)+@"
IconPart2ChoiceLIGHTY="+rnd.Next(1, 641)+@"
IconPart2ChoiceLIGHTOnCommand=cropbottom,1;sleep,0.317;cropbottom,0
IconPart2ChoiceLIGHTOffCommand=sleep,0.716;sleep,0.247;cropbottom,1
IconPart2ChoiceLIGHTOffFocusedCommand=
IconPart2ChoiceLIGHTOffUnfocusedCommand=
IconPart2ChoiceLIGHTEnabledCommand=
IconPart2ChoiceLIGHTGainFocusCommand=
IconPart2ChoiceLIGHTLoseFocusCommand=
IconPart2ChoiceLIGHTSwitchToPage1Command=
IconPart2ChoiceLIGHTSwitchToPage2Command=
IconPart2ChoiceSTANDARDX="+rnd.Next(1, 641)+@"
IconPart2ChoiceSTANDARDY="+rnd.Next(1, 641)+@"
IconPart2ChoiceSTANDARDOnCommand=draworder,9;croptop,0.769;cropbottom,0.127;cropleft,0.016;cropright,0.50625;sleep,0.317;sleep,0.233;linear,0.75;cropright,0.984
IconPart2ChoiceSTANDARDOffCommand=linear,0.716;cropright,0.50625
IconPart2ChoiceSTANDARDOffFocusedCommand=
IconPart2ChoiceSTANDARDOffUnfocusedCommand=
IconPart2ChoiceSTANDARDEnabledCommand=
IconPart2ChoiceSTANDARDGainFocusCommand=
IconPart2ChoiceSTANDARDLoseFocusCommand=
IconPart2ChoiceSTANDARDSwitchToPage1Command=linear,0.233;cropright,0.50625;linear,0.233;cropright,0.984
IconPart2ChoiceSTANDARDSwitchToPage2Command=linear,0.233;cropright,0.50625;linear,0.233;cropright,0.984
IconPart2ChoiceHEAVYX"+rnd.Next(1, 641)+@"
IconPart2ChoiceHEAVYY"+rnd.Next(1, 641)+@"
IconPart2ChoiceHEAVYOnCommand=draworder,9;croptop,0.769;cropbottom,0.127;cropright,0.016;cropleft,0.50625;sleep,0.317;sleep,0.233;linear,0.75;cropleft,0.984
IconPart2ChoiceHEAVYOffCommand=linear,0.716;cropleft,0.50625
IconPart2ChoiceHEAVYOffFocusedCommand=
IconPart2ChoiceHEAVYOffUnfocusedCommand=
IconPart2ChoiceHEAVYEnabledCommand=
IconPart2ChoiceHEAVYGainFocusCommand=
IconPart2ChoiceHEAVYLoseFocusCommand=
IconPart2ChoiceHEAVYSwitchToPage1Command=linear,0.233;cropleft,0.50625;linear,0.233;cropleft,0.984
IconPart2ChoiceHEAVYSwitchToPage2Command=linear,0.233;cropleft,0.50625;linear,0.233;cropleft,0.984
IconPart2ChoiceNONSTOPX="+rnd.Next(1, 641)+@"
IconPart2ChoiceNONSTOPY="+rnd.Next(1, 641)+@"
IconPart2ChoiceNONSTOPOnCommand=draworder,9;croptop,0.873;cropbottom,0.127;cropleft,0.016;cropright,0.016
IconPart2ChoiceNONSTOPOffCommand=sleep,0.716;linear,0.233;croptop,0.769
IconPart2ChoiceNONSTOPOffFocusedCommand=
IconPart2ChoiceNONSTOPOffUnfocusedCommand=
IconPart2ChoiceNONSTOPEnabledCommand=
IconPart2ChoiceNONSTOPGainFocusCommand=
IconPart2ChoiceNONSTOPLoseFocusCommand=
IconPart2ChoiceNONSTOPSwitchToPage1Command=
IconPart2ChoiceNONSTOPSwitchToPage2Command=
IconPart2ChoiceONIX="+rnd.Next(1, 641)+@"
IconPart2ChoiceONIY="+rnd.Next(1, 641)+@"
IconPart2ChoiceONIOnCommand=draworder,10
IconPart2ChoiceONIOffCommand=linear,0.467;addy,32;cropbottom,1
IconPart2ChoiceONIOffFocusedCommand=
IconPart2ChoiceONIOffUnfocusedCommand=
IconPart2ChoiceONIEnabledCommand=
IconPart2ChoiceONIGainFocusCommand=
IconPart2ChoiceONILoseFocusCommand=
IconPart2ChoiceONISwitchToPage1Command=linear,0.233;addx,-160
IconPart2ChoiceONISwitchToPage2Command=sleep,0.233;linear,0.233;addx,160
IconPart3ChoiceBEGINNERX=
IconPart3ChoiceBEGINNERY=
IconPart3ChoiceBEGINNEROnCommand=
IconPart3ChoiceBEGINNEROffCommand=
IconPart3ChoiceBEGINNEROffFocusedCommand=
IconPart3ChoiceBEGINNEROffUnfocusedCommand=
IconPart3ChoiceBEGINNEREnabledCommand=
IconPart3ChoiceBEGINNERGainFocusCommand=
IconPart3ChoiceBEGINNERLoseFocusCommand=
IconPart3ChoiceBEGINNERSwitchToPage1Command=
IconPart3ChoiceBEGINNERSwitchToPage2Command=
IconPart3ChoiceLIGHTX="+rnd.Next(1, 641)+@"
IconPart3ChoiceLIGHTY="+rnd.Next(1, 641)+@"
IconPart3ChoiceLIGHTOnCommand=draworder,5;diffusealpha,0
IconPart3ChoiceLIGHTOffCommand=sleep,0.716;cropbottom,1
IconPart3ChoiceLIGHTOffFocusedCommand=
IconPart3ChoiceLIGHTOffUnfocusedCommand=
IconPart3ChoiceLIGHTEnabledCommand=
IconPart3ChoiceLIGHTGainFocusCommand=
IconPart3ChoiceLIGHTLoseFocusCommand=
IconPart3ChoiceLIGHTSwitchToPage1Command=sleep,0.233;diffusealpha,0
IconPart3ChoiceLIGHTSwitchToPage2Command=sleep,0.233;diffusealpha,1
IconPart3ChoiceSTANDARDX="+rnd.Next(1, 641)+@"
IconPart3ChoiceSTANDARDY="+rnd.Next(1, 641)+@"
IconPart3ChoiceSTANDARDOnCommand=draworder,5;cropbottom,1;sleep,0.55;cropbottom,0
IconPart3ChoiceSTANDARDOffCommand=sleep,0.716;cropbottom,1
IconPart3ChoiceSTANDARDOffFocusedCommand=
IconPart3ChoiceSTANDARDOffUnfocusedCommand=
IconPart3ChoiceSTANDARDEnabledCommand=
IconPart3ChoiceSTANDARDGainFocusCommand=
IconPart3ChoiceSTANDARDLoseFocusCommand=
IconPart3ChoiceSTANDARDSwitchToPage1Command=sleep,0.233;diffusealpha,1
IconPart3ChoiceSTANDARDSwitchToPage2Command=sleep,0.233;diffusealpha,0
IconPart3ChoiceHEAVYX="+rnd.Next(1, 641)+@"
IconPart3ChoiceHEAVYY="+rnd.Next(1, 641)+@"
IconPart3ChoiceHEAVYOnCommand=draworder,9;croptop,0.769;cropbottom,0.127;cropleft,0.016;cropright,0.016;sleep,0.317;linear,0.233;croptop,0.873
IconPart3ChoiceHEAVYOffCommand=sleep,0.716;linear,0.233;croptop,0.769
IconPart3ChoiceHEAVYOffFocusedCommand=
IconPart3ChoiceHEAVYOffUnfocusedCommand=
IconPart3ChoiceHEAVYEnabledCommand=
IconPart3ChoiceHEAVYGainFocusCommand=
IconPart3ChoiceHEAVYLoseFocusCommand=
IconPart3ChoiceHEAVYSwitchToPage1Command=
IconPart3ChoiceHEAVYSwitchToPage2Command=
IconPart3ChoiceNONSTOPX="+rnd.Next(1, 641)+@"
IconPart3ChoiceNONSTOPY="+rnd.Next(1, 641)+@"
IconPart3ChoiceNONSTOPOnCommand=draworder,9;croptop,0.769;cropbottom,0.127;cropleft,0.016;cropright,0.984
IconPart3ChoiceNONSTOPOffCommand=linear,0.716;cropright,0.50625
IconPart3ChoiceNONSTOPOffFocusedCommand=
IconPart3ChoiceNONSTOPOffUnfocusedCommand=
IconPart3ChoiceNONSTOPEnabledCommand=
IconPart3ChoiceNONSTOPGainFocusCommand=
IconPart3ChoiceNONSTOPLoseFocusCommand=
IconPart3ChoiceNONSTOPSwitchToPage1Command=
IconPart3ChoiceNONSTOPSwitchToPage2Command=
IconPart3ChoiceONIX="+rnd.Next(1, 641)+@"
IconPart3ChoiceONIY="+rnd.Next(1, 641)+@"
IconPart3ChoiceONIOnCommand=draworder,9;croptop,0.769;cropbottom,0.127;cropright,0.016;cropleft,0.984
IconPart3ChoiceONIOffCommand=linear,0.716;cropleft,0.50625
IconPart3ChoiceONIOffFocusedCommand=
IconPart3ChoiceONIOffUnfocusedCommand=
IconPart3ChoiceONIEnabledCommand=
IconPart3ChoiceONIGainFocusCommand=
IconPart3ChoiceONILoseFocusCommand=
IconPart3ChoiceONISwitchToPage1Command=
IconPart3ChoiceONISwitchToPage2Command=

PreviewPart1P1X="+rnd.Next(1, 641)+@"
PreviewPart1P1Y="+rnd.Next(1, 641)+@"
PreviewPart1P1OnCommand=draworder,5;cropbottom,1;cropright,0.936;sleep,0.417;linear,0.267;cropbottom,0;sleep,0.016;linear,0.35;cropright,0
PreviewPart1P1OffCommand=sleep,0.233;linear,0.333;cropright,0.936;sleep,0.016;linear,0.268;cropbottom,1
PreviewPart1P1OffFocusedCommand=
PreviewPart1P1OffUnfocusedCommand=
PreviewPart1P1GainFocusCommand=diffusealpha,1
PreviewPart1P1LoseFocusCommand=diffusealpha,0
PreviewPart1P1PreSwitchPageCommand=sleep,0.24;diffusealpha,0
PreviewPart1P1PostSwitchPageCommand=diffusealpha,1
PreviewPart1P2X="+rnd.Next(1, 641)+@"
PreviewPart1P2Y="+rnd.Next(1, 641)+@"
PreviewPart1P2OnCommand=draworder,5;cropbottom,1;cropleft,0.936;sleep,0.417;linear,0.267;cropbottom,0;sleep,0.016;linear,0.35;cropleft,0
PreviewPart1P2OffCommand=sleep,0.233;linear,0.333;cropleft,0.936;sleep,0.016;linear,0.268;cropbottom,1
PreviewPart1P2OffFocusedCommand=
PreviewPart1P2OffUnfocusedCommand=
PreviewPart1P2GainFocusCommand=diffusealpha,1
PreviewPart1P2LoseFocusCommand=diffusealpha,0
PreviewPart1P2PreSwitchPageCommand=sleep,0.24;diffusealpha,0
PreviewPart1P2PostSwitchPageCommand=diffusealpha,1

PreviewPart2P1X="+rnd.Next(1, 641)+@"
PreviewPart2P1Y="+rnd.Next(1, 641)+@"
PreviewPart2P1OnCommand=vertalign,top;zoomy,0;sleep,0.134;linear,0.25;zoomy,1
PreviewPart2P1OffCommand=sleep,0.566;linear,0.267;zoomy,0
PreviewPart2P1OffFocusedCommand=
PreviewPart2P1OffUnfocusedCommand=
PreviewPart2P1GainFocusCommand=diffusealpha,1
PreviewPart2P1LoseFocusCommand=diffusealpha,0
PreviewPart2P1PreSwitchPageCommand=sleep,0.24;diffusealpha,0
PreviewPart2P1PostSwitchPageCommand=diffusealpha,1
PreviewPart2P2X="+rnd.Next(1, 641)+@"
PreviewPart2P2Y="+rnd.Next(1, 641)+@"
PreviewPart2P2OnCommand=vertalign,top;zoomy,0;sleep,0.134;linear,0.25;zoomy,1
PreviewPart2P2OffCommand=sleep,0.566;linear,0.267;zoomy,0
PreviewPart2P2OffFocusedCommand=
PreviewPart2P2OffUnfocusedCommand=
PreviewPart2P2GainFocusCommand=diffusealpha,1
PreviewPart2P2LoseFocusCommand=diffusealpha,0
PreviewPart2P2PreSwitchPageCommand=sleep,0.24;diffusealpha,0
PreviewPart2P2PostSwitchPageCommand=diffusealpha,1

[ScreenSelectMasterVersus]
Fallback=ScreenSelectMaster
Class=ScreenSelectMaster

[ScreenSelectMasterDouble]
Fallback=ScreenSelectMaster
Class=ScreenSelectMaster
NumChoices=5
ChoiceNames=1,2,3,4,5
OptionOrderLeftP1=5:4,4:3,3:2,2:1
OptionOrderRightP1=1:2,2:3,3:4,4:5
OptionOrderLeftP2=5:4,4:3,3:2,2:1
OptionOrderRightP2=1:2,2:3,3:4,4:5
NumChoicesOnPage1=3
Choice1=PlayMode,regular;Difficulty,easy;name,LIGHT
Choice2=PlayMode,regular;Difficulty,medium;name,STANDARD
Choice3=PlayMode,regular;Difficulty,hard;name,HEAVY
Choice4=PlayMode,nonstop;name,NONSTOP
Choice5=PlayMode,oni;name,ONI
IconPart1ChoiceLIGHTX="+rnd.Next(1, 641)+@"
IconPart1ChoiceSTANDARDX="+rnd.Next(1, 641)+@"
IconPart1ChoiceHEAVYX="+rnd.Next(1, 641)+@"
IconPart3ChoiceSTANDARDX="+rnd.Next(1, 641)+@"
IconPart3ChoiceSTANDARDOnCommand=draworder,5;cropleft,0.25;cropbottom,1;sleep,0.55;cropbottom,0

[ScreenInstructions]
MemoryCardIcons=0
StyleIcon=0

[GrooveRadar]
Label1OffsetX="+rnd.Next(-31, 641)+@"	// stream
Label1OffsetY="+rnd.Next(-31, 641)+@"
Label2OffsetX="+rnd.Next(-31, 641)+@"	// voltage
Label2OffsetY="+rnd.Next(-31, 641)+@"
Label3OffsetX="+rnd.Next(-31, 641)+@"	// air
Label3OffsetY="+rnd.Next(-31, 641)+@"
Label4OffsetX="+rnd.Next(-31, 641)+@"	// freeze
Label4OffsetY="+rnd.Next(-31, 641)+@"
Label5OffsetX="+rnd.Next(-31, 641)+@"	// chaos
Label5OffsetY="+rnd.Next(-31, 641)+@"
DisableRadar=0     // turn this to 1 if you are experiencing trouble with the groove radar (voodoo3's)
LabelOnCommand=addx,16;diffusealpha,0
LabelOnDelay=0.058
// begin fading on screen and fly to the right
LabelOnCommandPostDelay=sleep,0.533;decelerate,0.116;diffusealpha,1;addx,-16
LabelOffCommand=
LabelOffCommandPostDelay=sleep,0.2;decelerate,0.116;diffusealpha,1;addx,-16
BaseOnCommand=zoom,0;sleep,0.583;decelerate,0.150;zoom,1
BaseOffCommand=sleep,0.183;decelerate,0.167;zoom,0
//BaseOnCommand=zoom,0;rotationz,-360;sleep,0.3;decelerate,0.4;rotationz,0;zoom,1
//BaseOffCommand=sleep,0.4;accelerate,0.383;zoom,0;rotationz,-360


[DifficultyMeter]
NumFeetInMeter=13
MaxFeetInMeter=13
GlowIfMeterGreaterThan=10
FeetOnCommand=x,0;y,-11;shadowlength,0;vertalign,top;zoomy,0;sleep,0.733;linear,0.083;zoomy,0.9
//FeetOffCommand=vertalign,top;sleep,0.2;linear,0.083;zoomy,0
FeetOffCommand=
FeetIsDifficultyColor=1
ShowFeet="+rnd.Next(1, 2)+@"
ShowDifficulty="+rnd.Next(1, 2)+@"
ShowMeter="+rnd.Next(1, 2)+@"
FeetPerDifficulty=0
MeterY="+rnd.Next(1, 481)+@"
MeterOnCommand=shadowlength,0;cropbottom,1;sleep,0.816;cropbottom,0
MeterSetNoneCommand=
MeterSetBeginnerCommand=diffuse,0,1,0.66,1
MeterSetEasyCommand=diffuse,1,0.61,0.02,1
MeterSetMediumCommand=diffuse,1,0.45,0,1
MeterSetHardCommand=diffuse,0.3,0.73,0.3,1
MeterSetChallengeCommand=diffuse,0.61,0.26,1,1
MeterSetEditCommand=diffuse,1,1,0,1
FeetGlowCommand=glowshift;effectperiod,1.0;effectcolor1,0,0,0,0;effectcolor2,0,0,0,0.4
MeterSetRegularCourseCommand=diffuse,#F800A0
MeterSetDifficultCourseCommand=diffuse,#68F800
MeterP1X="+rnd.Next(1, 641)+@"
FeetP1X="+rnd.Next(1, 641)+@"
MeterP2X="+rnd.Next(1, 641)+@"
FeetP2X="+rnd.Next(1, 641)+@"
MeterY="+rnd.Next(1, 481)+@"
FeetY="+rnd.Next(1, 481)+@"

[EditDifficultyMeter]
FeetGlowCommand=glowshift;effectperiod,1.0;effectcolor1,0,0,0,0;effectcolor2,0,0,0,0.4
FeetP2X="+rnd.Next(1, 641)+@"
FeetP2Y="+rnd.Next(1, 481)+@"
MeterP2X="+rnd.Next(1, 641)+@"
MeterP2Y="+rnd.Next(1, 481)+@"
MeterY="+rnd.Next(1, 481)+@"

[BPMDisplay]
NormalColor=1,1,1,1
ChangeColor=1,0,1,1
ExtraColor=1,0,0,1
Cycle=1
NoBPMText="+rnd.Next(1, 1000)+@"
TextX="+rnd.Next(1, 641)+@"
TextY="+rnd.Next(1, 481)+@"
TextOnCommand=horizalign,right;shadowlength,0
LabelX="+rnd.Next(1, 641)+@"
LabelY="+rnd.Next(1, 481)+@"
LabelOnCommand=horizalign,left

[TextBanner]
ArtistPrependString=/
TwoLinesTitleCommand=shadowlength,0;horizalign,left;zoom,1;maxwidth,192;x,-96;y,-7
TwoLinesArtistCommand=shadowlength,0;horizalign,left;zoom,0.55;maxwidth,349;x,-96;y,9
ThreeLinesTitleCommand=shadowlength,0;horizalign,left;zoom,0.7;maxwidth,274;x,-96;y,-10
ThreeLinesSubTitleCommand=shadowlength,0;horizalign,left;zoom,0.7;maxwidth,274;x,-96;y,0
ThreeLinesArtistCommand=shadowlength,0;horizalign,left;zoom,0.55;maxwidth,349;x,-96;y,9
CardX=-1
CardY=0
//CardOnCommand=glow,1,1,1,0.2

[TextBanner2]
Fallback=TextBanner


[MusicWheelItem]
IconX="+rnd.Next(1, 641)+@"
SectionZoom=0.8
SectionZoomX=1
SectionZoomY=1
SectionNameOnCommand=shadowlength,0;horizAlign,left
SectionNameX=-"+rnd.Next(-31, 641)+@"
SongNameX="+rnd.Next(-641, 641)+@"
SongNameOnCommand=horizAlign,left
TextBanner2OnCommand=blend,add
RouletteX="+rnd.Next(-31, 641)+@"
RouletteZoom=0.97
RouletteOnCommand=horizalign,left
GradeP1X="+rnd.Next(-31, 641)+@"
GradeP2X="+rnd.Next(-31, 641)+@"
AbcX="+rnd.Next(-31, 641)+@"
AbcZoomX=1
AbcZoomY=1
MaxTextWidth="+rnd.Next(-31, 641)+@"
CourseNameX="+rnd.Next(-31, 641)+@"
CourseNameY="+rnd.Next(-31, 641)+@"
CardSectionX="+rnd.Next(-31, 641)+@"
CardSectionY="+rnd.Next(-31, 641)+@"
CardCourseX="+rnd.Next(-31, 641)+@"
CardCourseY="+rnd.Next(-31, 641)+@"
CardRouletteX="+rnd.Next(-31, 641)+@"
CardRouletteY="+rnd.Next(-31, 641)+@"

[OptionIcon]
TextOffsetX="+rnd.Next(-31, 641)+@"
TextOffsetY="+rnd.Next(-31, 641)+@"
TextHAlign="+rnd.Next(-31, 641)+@"	// 0,1,2 = left,center,right
TextVAlign="+rnd.Next(-31, 641)+@"	// 0,1,2 = top,middle,bottom
TextWidth="+rnd.Next(-31, 641)+@"
TextZoom=1
Uppercase=1
OptionPicX="+rnd.Next(-31, 641)+@"
OptionPicY="+rnd.Next(-31, 641)+@"

[OptionIconRow]
SpacingX="+rnd.Next(-31, 641)+@"
SpacingY="+rnd.Next(1, 641)+@"

[CodeDetector]
//misc
NextSort2=MenuLeft+MenuRight
NextSort4=Left+Right
CancelAll=Left,Right,Left,Right,Left,Right,Left,Right
NextScrollSpeed=Up,Up,Left,Down,Left
PreviousScrollSpeed=Down,Down,Right,Up,Right
NextAccel=Left,Right,Down,Up
NextAppearance=Left,Up,Right
Left=Up,Down,Right,Left
Right=Up,Down,Left,Right
Mirror=Up,Left,Right,Left,Right
Shuffle=Up,Down,Up,Down,Up,Down
NextTurn=Left,Down,Right
Reverse=Down,Left,Right,Left,Right
HoldNotes=Right,Left,Down,Up
Easier1=Up,Up
Easier2=MenuUp,MenuUp
Harder1=Down,Down
Harder2=MenuDown,MenuDown
Dark=
SuperShuffle=
NextEffect=
NextTheme=
NextTheme2=
NextAnnouncer=
NextAnnouncer2=
NextGame=
NextGame2=
SortMenu1=
SortMenu2=

[MusicWheel]
ItemSpacingY="+rnd.Next(-31, 641)+@"
ItemCurveX="+rnd.Next(-31, 641)+@"
MusicWheelItemStartOnCommand=addx,350
MusicWheelItemFinishOnCommand=sleep,0.4;decelerate,0.35;addx,-350
MusicWheelItemStartOffCommand=
MusicWheelItemFinishOffCommand=accelerate,0.35;addx,350
MusicWheelItemStartOnSortCommand=addx,350
MusicWheelItemFinishOnSortCommand=sleep,0.05;decelerate,0.133;addx,-350
MusicWheelItemStartOffSortCommand=
MusicWheelItemFinishOffSortCommand=accelerate,0.133;addx,350
WheelItemOnDelayOffset=0.041
WheelItemOnDelayCenter=0
WheelItemOnDelayOffsetSort=0.016
;WheelItemOffDelayOffset=0.041
WheelItemOffDelayCenter=0
WheelItemOffDelayOffsetSort=0.016
ScrollBarX="+rnd.Next(-31, 641)+@"
ScrollBarHeight="+rnd.Next(-31, 641)+@"
HighlightFinishOffCommand=accelerate,0.2;addx,350
HighlightFinishOffSortCommand=accelerate,0.066;addx,350;sleep,0.216
//note: the times for sort off/on command are not real - SM speeds this up. the real times are in the score frame animation
HighlightFinishOnCommand=sleep,0.9;decelerate,0.2;addx,-350
HighlightFinishOnSortCommand=sleep,0.083;decelerate,0.066;addx,-350
HighlightOnCommand=diffuseshift;blend,add;effectcolor1,0.2,0.33,0,1;effectcolor2,0.2,0.33,0,0;effectperiod,1.085
HighlightStartOffCommand=
HighlightStartOnCommand=addx,350
GroupSectionColor=#ff8400 //orange
SortChangeHurry=0.7
SortChangeOffDuration=0.25
NumSectionColors=1
SectionColor1=1,1,0,1
ShowRandom="+rnd.Next(1, 2)+@"
ShowRoulette="+rnd.Next(1, 2)+@"
SongRealExtraColor=0.85,0.1,0.1,1
MostPlayedSongsToShow=50

[ScreenBranchSelectSongOrCourse]
Class=ScreenBranch
Choices=1,2,3,4
Condition1=PlayModeName() == "+'"'+"Nonstop"+'"'+@"
Condition2=PlayModeName() == "+'"'+"Oni"+'"'+@"
Condition3=CurStyleName() == "+'"'+"versus"+'"'+@"
Condition4=true
NextScreen1=screen,ScreenSelectCourseNonstop
NextScreen2=screen,ScreenSelectCourseOni
NextScreen3=screen,ScreenSelectMusicVersus
NextScreen4=screen,ScreenSelectMusic

[Banner]
ScrollRandom="+rnd.Next(1, 2)+@"
ScrollRoulette="+rnd.Next(1, 2)+@"

[ScreenSelectMusic]
Fallback=ScreenWithMenuElements
TimerSeconds="+rnd.Next(1, 100)+@"
AnimBPMDisplayOffCommand=
AnimBPMDisplayOnCommand=draworder,1
AnimBPMDisplayX="+rnd.Next(1, 641)+@"
AnimBPMDisplayY="+rnd.Next(1, 481)+@"
BalloonX="+rnd.Next(1, 641)+@"
BalloonY="+rnd.Next(1, 481)+@"
BalloonOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
BalloonOffCommand=accelerate,0.316;addx,-280
BalloonHideCommand=diffusealpha,0
BalloonShowCommand=diffusealpha,1
BannerFrameX="+rnd.Next(1, 641)+@"
BannerFrameY="+rnd.Next(1, 481)+@"
BannerFrameOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
BannerFrameOffCommand=accelerate,0.316;addx,-280
BannerX="+rnd.Next(1, 641)+@"
BannerY="+rnd.Next(1, 481)+@"
BannerOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
BannerOffCommand=accelerate,0.316;addx,-280
BannerWidth="+rnd.Next(1, 641)+@"
BannerHeight="+rnd.Next(1, 481)+@"
BPMDisplayX="+rnd.Next(1, 641)+@"
BPMDisplayY="+rnd.Next(1, 481)+@"
BPMDisplayOnCommand=addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
BPMDisplayOffCommand=accelerate,0.316;addx,-280
WheelX="+rnd.Next(1, 641)+@"
WheelY="+rnd.Next(1, 481)+@"
FooterX="+rnd.Next(1, 641)+@"
FooterY="+rnd.Next(1, 481)+@"
FooterOnCommand=draworder,1
RadarX="+rnd.Next(-31, 641)+@"
RadarY="+rnd.Next(-31, 641)+@"
CDTitleX="+rnd.Next(1, 641)+@"
CDTitleY="+rnd.Next(1, 481)+@"
CDTitleFrontCommand=spin;effectmagnitude,0,180,0;cullmode,back
CDTitleBackCommand=spin;effectmagnitude,0,180,0;cullmode,front;diffuse,#333333
CDTitleOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
CDTitleOffCommand=accelerate,0.316;addx,-280

CDTitleSpinSeconds=2.16
DifficultyFrameP1X="+rnd.Next(-31, 641)+@"
DifficultyFrameP1Y="+rnd.Next(-31, 641)+@"
DifficultyFrameP1OnCommand=addy,40;cropbottom,1;sleep,0.717;decelerate,0.183;addy,-40;cropbottom,0
DifficultyFrameP1OffCommand=sleep,0.2;accelerate,0.183;addy,40;cropbottom,1
DifficultyFrameP2X="+rnd.Next(-31, 641)+@"
DifficultyFrameP2Y="+rnd.Next(-31, 641)+@"
DifficultyFrameP2OnCommand=addy,40;cropbottom,1;sleep,0.717;decelerate,0.183;addy,-40;cropbottom,0
DifficultyFrameP2OffCommand=sleep,0.2;accelerate,0.183;addy,40;cropbottom,1
DifficultyIconP1X="+rnd.Next(-31, 641)+@"
DifficultyIconP1Y="+rnd.Next(-31, 641)+@"
DifficultyIconP1OnCommand=addy,40;cropbottom,1;sleep,0.717;decelerate,0.183;addy,-40;cropbottom,0
DifficultyIconP1OffCommand=sleep,0.2;accelerate,0.183;addy,40;cropbottom,1
DifficultyIconP2X="+rnd.Next(-31, 641)+@"
DifficultyIconP2Y="+rnd.Next(-31, 641)+@"
DifficultyIconP2OnCommand=addy,40;cropbottom,1;sleep,0.717;decelerate,0.183;addy,-40;cropbottom,0
DifficultyIconP2OffCommand=sleep,0.2;accelerate,0.183;addy,40;cropbottom,1
DifficultyDisplayOnCommand=hidden,1
DoRouletteOnMenuTimer=0
ExplanationX="+rnd.Next(-31, 641)+@"
ExplanationY="+rnd.Next(-31, 641)+@"
ExplanationOnCommand=addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
ExplanationOffCommand=accelerate,0.316;addx,-280
MeterFrameP1X="+rnd.Next(-31, 641)+@"
MeterFrameP1Y="+rnd.Next(-31, 641)+@"
MeterFrameP1OnCommand=cropbottom,1;sleep,0.533;linear,0.184;cropbottom,0
MeterFrameP1OffCommand=sleep,0.183;linear,0.2;cropbottom,1
MeterFrameP2X="+rnd.Next(-31, 641)+@"
MeterFrameP2Y="+rnd.Next(-31, 641)+@"
MeterFrameP2OnCommand=cropbottom,1;sleep,0.533;linear,0.184;cropbottom,0
MeterFrameP2OffCommand=sleep,0.183;linear,0.2;cropbottom,1
MeterP1X="+rnd.Next(-31, 641)+@"
MeterP1Y="+rnd.Next(-31, 641)+@"
MeterP2X="+rnd.Next(-31, 641)+@"
MeterP2Y="+rnd.Next(-31, 641)+@"
MeterP1OnCommand=
MeterP2OnCommand=
NextScreen=ScreenBranchGameplay
OptionIconsP1X="+rnd.Next(-31, 641)+@"
OptionIconsP1Y="+rnd.Next(-31, 641)+@"
OptionIconsP1OnCommand=draworder,2;addx,-640;sleep,0.317;decelerate,0.766;addx,640
OptionIconsP1OffCommand=accelerate,0.783;addx,-640
OptionIconsP2X="+rnd.Next(-31, 641)+@"
OptionIconsP2Y="+rnd.Next(-31, 641)+@"
OptionIconsP2OnCommand=draworder,2;addx,-640;sleep,0.317;decelerate,0.766;addx,640
OptionIconsP2OffCommand=accelerate,0.783;addx,-640
ScoreFrameP1X="+rnd.Next(-31, 641)+@"
ScoreFrameP1Y="+rnd.Next(-31, 641)+@"
ScoreFrameP1OnCommand=addx,350;sleep,0.9;decelerate,0.2;addx,-350
ScoreFrameP1SortChangeCommand=accelerate,0.066;addx,350;sleep,0.400;decelerate,0.066;addx,-350
ScoreFrameP1OffCommand=accelerate,0.2;addx,350
ScoreFrameP2X="+rnd.Next(-31, 641)+@"
ScoreFrameP2Y="+rnd.Next(-31, 641)+@"
ScoreFrameP2OnCommand=addx,350;sleep,0.9;decelerate,0.2;addx,-350
ScoreFrameP2SortChangeCommand=accelerate,0.066;addx,350;sleep,0.400;decelerate,0.066;addx,-350
ScoreFrameP2OffCommand=accelerate,0.2;addx,350
ScoreP1OnCommand=hidden,1
ScoreP2OnCommand=hidden,1
DefaultSort=DEFAULTLIST
SongOptionsOnCommand=hidden,1
SortIconSortChangeCommand=accelerate,0.18;addy,30;sleep,0.200;decelerate,0.18;addy,-30
SortIconX="+rnd.Next(-31, 641)+@"
SortIconY="+rnd.Next(-31, 641)+@"
SortIconOnCommand=draworder,1;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
SortIconOffCommand=accelerate,0.316;addx,-280
StageX="+rnd.Next(-31, 641)+@"
StageY="+rnd.Next(-31, 641)+@"
StageOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
StageOffCommand=accelerate,0.316;addx,-280
ItemNameX="+rnd.Next(-31, 641)+@"
ItemNameY="+rnd.Next(-31, 641)+@"
ItemNameOnCommand=draworder,2;horizalign,left;shadowlength,0;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
ItemNameOffCommand=accelerate,0.316;addx,-280
ItemNameCardX="+rnd.Next(-31, 641)+@"
ItemNameCardY="+rnd.Next(-31, 641)+@"
ItemNameCardOnCommand=draworder,2;horizalign,left;shadowlength,0;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
ItemNameCardOffCommand=accelerate,0.316;addx,-280

[ScreenSelectMusicVersus]
Fallback=ScreenSelectMusic
Class=ScreenSelectMusic

[ScreenSelectCourse]
Fallback=ScreenSelectMusic
BannerFrameY="+rnd.Next(-31, 641)+@"
BannerY="+rnd.Next(-31, 641)+@"
BPMDisplayOnCommand=hidden,1
CDTitleOnCommand=hidden,1
CourseContentsX="+rnd.Next(-31, 641)+@"
CourseContentsY="+rnd.Next(-31, 641)+@"
CourseContentsOnCommand=draworder,2;addx,-280;sleep,0.450;linear,0.267;addx,274;linear,0.05;addx,-6;decelerate,0.116;addx,12;decelerate,0.067;addx,-4;decelerate,0.1;addx,4
CourseContentsOffCommand=accelerate,0.316;addx,-280
DoRouletteOnMenuTimer=0
RadarOnCommand=hidden,1
MeterP1OnCommand=hidden,1
MeterP2OnCommand=hidden,1
ItemNameX="+rnd.Next(-31, 641)+@"
ItemNameY="+rnd.Next(-31, 641)+@"
ItemNameCardX="+rnd.Next(-31, 641)+@"
ItemNameCardY="+rnd.Next(-31, 641)+@"

[ScreenSelectCourseOni]
Fallback=ScreenSelectCourse
ScoreFrameP1OnCommand=addx,350;sleep,0.9;decelerate,0.2;addx,-350
ScoreFrameP2OnCommand=addx,350;sleep,0.9;decelerate,0.2;addx,-350
OptionIconsP1OnCommand=hidden,1
OptionIconsP2OnCommand=hidden,1
NextOptionsScreen=ScreenBranchGameplay

[CourseEntryDisplay]
BarX="+rnd.Next(-31, 641)+@"
BarY="+rnd.Next(-31, 641)+@"
BarOnCommand=
TextBannerName=TextBanner
TextBannerX="+rnd.Next(-31, 641)+@"
TextBannerY="+rnd.Next(-31, 641)+@"
TextBannerOnCommand=shadowlength,0
NumberX="+rnd.Next(-31, 641)+@"
NumberY="+rnd.Next(-31, 641)+@"
NumberOnCommand=shadowlength,0
FootX="+rnd.Next(-31, 641)+@"
FootY="+rnd.Next(-31, 641)+@"
FootOnCommand=shadowlength,0;zoom,0.8
SeparateCourseMeters=0
DifficultyX="+rnd.Next(-31, 641)+@"
DifficultyY="+rnd.Next(-31, 641)+@"
DifficultyOnCommand=zoom,1;shadowlength,0
ModifiersOnCommand=hidden,1

[SongManager]
BeginnerColor=0.03,1,1,1
EasyColor=1,0.67,0,1
MediumColor=1,0,0.61,1
HardColor=0.39,1,0,1
ChallengeColor=0.45,0.41,1,1
EditColor=1,1,0,1
ExtraColor=0.96,0,0,1
CourseListEnabled=0
DefaultListNumEntries=0
DefaultListEnabled=0
//ddrex song colors for ddr extreme arcade song groups, in real order for numbered entries
NumGroupColors=21
GroupColor1=#00FF4A
GroupColor2=#E700FF
GroupColor3=#E700FF
GroupColor4=#E700FF
GroupColor5=#FFFF00
GroupColor6=#FFFF00
GroupColor7=#FFFF00
GroupColor8=#FFFF00
GroupColor9=#FFFF00
GroupColor10=#FFFF00
GroupColor11=#FFFF00
GroupColor12=#FFFF00
GroupColor13=#FFFF00
GroupColor14=#00C6FF
GroupColor15=#00C6FF
GroupColor16=#00C6FF
GroupColor17=#00C6FF
GroupColor18=#00C6FF
GroupColor19=#00C6FF
GroupColor20=#00C6FF
GroupColor21=#EA52AA

DefaultListEnabled=1
DefaultListExclusive=0

DefaultListNumEntries=84

DefaultList1=Songs/ex01/GRADUATION~SOREZORE NO ASHITA~/
DefaultList2=Songs/ex01/1998/
DefaultList3=Songs/ex01/LA COPA DE LA VIDA/
DefaultList4=Songs/ex01/LOVE LOVE SHINE/
DefaultList5=Songs/ex01/WE ARE THE CHAMPIONS (Factory Team Remix)/
DefaultList6=Songs/ex01/WE WILL ROCK YOU/
DefaultList7=Songs/ex01/I DO I DO I DO/
DefaultList8=Songs/ex01/HYPER EUROBEAT/
DefaultList9=Songs/ex01/MEMORIES/
DefaultList10=Songs/ex01/VANITY ANGEL/
DefaultList11=Songs/ex01/CRASH!/
DefaultList12=Songs/ex01/SENORITA(Speedy Mix)/
DefaultList13=Songs/ex01/SPEED OVER BEETHOVEN/
DefaultList14=Songs/ex01/IRRESISTIBLEMENT/
DefaultList15=Songs/ex01/BURNIN' THE FLOOR (MOMO MIX)/
DefaultList16=Songs/ex01/CARTOON HEROES (Speedy Mix)/
DefaultList17=Songs/ex01/TEARS/
DefaultList18=Songs/ex01/bag/

DefaultList19=Songs/ex14/LET'S GET DOWN/
DefaultList20=Songs/ex19/TELEPHONE OPERATOR (Club MIX)/
DefaultList21=Songs/ex14/BUTTERFLY/
DefaultList22=Songs/ex15/EL RITMO TROPICAL/
DefaultList23=Songs/ex16/DAM DARIRAM/
DefaultList24=Songs/ex17/SYNCHRONIZED LOVE (Red Monster Hyper Mix)/
DefaultList25=Songs/ex14/LITTLE BITCH/
DefaultList26=Songs/ex17/SAINT GOES MARCHING (REMIX)/
DefaultList27=Songs/ex15/IF YOU WERE HERE/
DefaultList28=Songs/ex17/RHYTHM AND POLICE (K.O.G G3 Mix)/
DefaultList29=Songs/ex15/GET UP'N MOVE/
DefaultList30=Songs/ex15/I believe in miracles/
DefaultList31=Songs/ex16/CAPTAIN JACK (GRANDALE REMIX)/

DefaultList32=Songs/ex12/HOLD ON ME/
DefaultList33=Songs/ex06/Happy Wedding/
DefaultList34=Songs/ex05/Miracle Moon ~L.E.D.LIGHT STYLE MIX~/
DefaultList35=Songs/ex08/White Lovers/
DefaultList36=Songs/ex05/air/
DefaultList37=Songs/ex09/I'm gonna get you!/
DefaultList38=Songs/ex10/JANEJANA/
DefaultList39=Songs/ex08/LOVE LOVE SUGAR/
DefaultList40=Songs/ex09/Mikeneko Rock/
DefaultList41=Songs/ex11/Pink Rose/
DefaultList42=Songs/ex10/STAY (Organic house Version)/
DefaultList43=Songs/ex09/Destiny lovers/
DefaultList44=Songs/ex06/AOI SHOUDOU(for EXTREME)/
DefaultList45=Songs/ex07/feeling of love/
DefaultList46=Songs/ex10/KISS ME ALL NIGHT LONG/
DefaultList47=Songs/ex06/Last Message/
DefaultList48=Songs/ex10/MOBO MOGA/
DefaultList49=Songs/ex13/Gamelan de Couple/
DefaultList50=Songs/ex13/LA BAMBA/
DefaultList51=Songs/ex06/Colors(for EXTREME)/
DefaultList52=Songs/ex10/KISS KISS KISS/
DefaultList53=Songs/ex08/MAHOU NO TOBIRA (SUPEESU MAKO NO TEEMU)/
DefaultList54=Songs/ex05/BE LOVIN/
DefaultList55=Songs/ex06/L'amour et la liberte (DDR ver.)/
DefaultList56=Songs/ex11/Frozen Ray (for EXTREME)/
DefaultList57=Songs/ex09/JET WORLD/
DefaultList58=Songs/ex08/Daikenkai/
DefaultList59=Songs/ex06/V(for EXTREME)/
DefaultList60=Songs/ex10/Heaven is a '57 metallic gray (gimmix)/
DefaultList61=Songs/ex07/TwinBee ~Generation X~/
DefaultList62=Songs/ex05/321 STARS/
DefaultList63=Songs/ex06/A/
DefaultList64=Songs/ex06/stoic(EXTREME version)/
DefaultList65=Songs/ex06/sync(EXTREME version)/
DefaultList66=Songs/ex09/Across the nightmare/
DefaultList67=Songs/ex06/Xenon/
DefaultList68=Songs/ex09/The Least 100sec/
DefaultList69=Songs/ex06/Sakura/

DefaultList70=Songs/ex04/CUTIE CHASER (Morning Mix)/
DefaultList71=Songs/ex04/DROP THE BOMB (System S.F. Mix)/
DefaultList72=Songs/ex02/SKY HIGH [solo]/
DefaultList73=Songs/ex04/DYNAMITE RAVE (Down Bird SOTA Mix)/
DefaultList74=Songs/ex04/Do It Right (Harmonized 2Step Mix)/
DefaultList75=Songs/ex04/Look To The Sky (True Color Mix)/
DefaultList76=Songs/ex04/So In Love/
DefaultList77=Songs/ex04/Kind Lady/
DefaultList78=Songs/ex04/AM-3P (303 BASSMIX)/

DefaultList79=Songs/New Songs

DefaultList80=Songs/ex01/Dance Dance Revolution/
DefaultList81=Songs/ex01/TRIP MACHINE survivor/
DefaultList82=Songs/ex01/PARANOiA survivor/
DefaultList83=Songs/ex01/PARANOiA survivor MAX/
DefaultList84=Songs/ex01/The legend of MAX/
CourseListEnabled=1
NonstopListEnabled=1
NonstopListNumEntries=25
NonstopList1Path=Courses/nonstop/POP 4.crs
NonstopList1Color=#00FF4A

NonstopList2Path=Courses/nonstop/DANCEMANIA -NONSTOP-.crs
NonstopList2Color=#FFFF00
NonstopList3Path=Courses/nonstop/MACHO.crs
NonstopList3Color=#FFFF00
NonstopList4Path=Courses/nonstop/HOUSE.crs
NonstopList4Color=#FFFF00
NonstopList5Path=Courses/nonstop/LOVE HEART.crs
NonstopList5Color=#FFFF00

NonstopList6Path=Courses/nonstop/PLAYER'S BEST 01-04.crs
NonstopList6Color=#00C6FF
NonstopList7Path=Courses/nonstop/PLAYER'S BEST 05-08.crs
NonstopList7Color=#00C6FF
NonstopList8Path=Courses/nonstop/PLAYER'S BEST 09-12.crs
NonstopList8Color=#00C6FF
NonstopList9Path=Courses/nonstop/PLAYER'S BEST 13-16.crs
NonstopList9Color=#00C6FF
NonstopList10Path=Courses/nonstop/PLAYER'S BEST 17-20.crs
NonstopList10Color=#00C6FF
NonstopList11Path=Courses/nonstop/PLAYER'S WORST.crs
NonstopList11Color=#00C6FF
NonstopList12Path=Courses/nonstop/RANDOM DANCEMANIA.crs
NonstopList12Color=#00C6FF
NonstopList13Path=Courses/nonstop/RANDOM BEMANI.crs
NonstopList13Color=#00C6FF
NonstopList14Path=Courses/nonstop/RANDOM ALL.crs
NonstopList14Color=#00C6FF
NonstopList15Path=Courses/nonstop/RANDOM CAPRICE.crs
NonstopList15Color=#00C6FF

NonstopList16Path=Courses/nonstop/THE FIRST.crs
NonstopList16Color=#E700FF
NonstopList17Path=Courses/nonstop/FINE CHOICE NONSTOP.crs
NonstopList17Color=#E700FF
NonstopList18Path=Courses/nonstop/HOP STEP.crs
NonstopList18Color=#E700FF
NonstopList19Path=Courses/nonstop/FROM Dance Maniax.crs
NonstopList19Color=#E700FF
NonstopList20Path=Courses/nonstop/FOUR SEASONS.crs
NonstopList20Color=#E700FF
NonstopList21Path=Courses/nonstop/FROM beatmania.crs
NonstopList21Color=#E700FF
NonstopList22Path=Courses/nonstop/EURO BEAT.crs
NonstopList22Color=#E700FF
NonstopList23Path=Courses/nonstop/FROM pop'n music.crs
NonstopList23Color=#E700FF
NonstopList24Path=Courses/nonstop/FUNKY GROOVE.crs
NonstopList24Color=#E700FF
NonstopList25Path=Courses/nonstop/DDR HOME VERSION.crs
NonstopList25Color=#E700FF

//list of oni courses
OniListEnabled=1
OniListNumEntries=30
OniList1Path=Courses/oni/NAOKI NEO-STANDARD.crs
OniList1Color=#38EA38
OniList2Path=Courses/oni/DANCEMANIA -ONI-.crs
OniList2Color=#38EA38

OniList3Path=Courses/oni/PARANOIA BROTHERS (extreme).crs
OniList3Color=#FFFF00
OniList4Path=Courses/oni/TRIP FIVE.crs
OniList4Color=#FFFF00
OniList5Path=Courses/oni/CLASSIC.crs
OniList5Color=#FFFF00
OniList6Path=Courses/oni/ROAD OF 2MB.crs
OniList6Color=#FFFF00
OniList7Path=Courses/oni/WORLD TOUR.crs
OniList7Color=#FFFF00
OniList8Path=Courses/oni/TRICK.crs
OniList8Color=#FFFF00
OniList9Path=Courses/oni/CLUB ver.crs
OniList9Color=#FFFF00

OniList10Path=Courses/oni/SORROW.crs
OniList10Color=#E700FF
OniList11Path=Courses/oni/ROAD OF TaQ.crs
OniList11Color=#E700FF
OniList12Path=Courses/oni/FROM GF&DM.crs
OniList12Color=#E700FF
OniList13Path=Courses/oni/RevenG NEW-REVENGE.crs
OniList13Color=#E700FF
OniList14Path=Courses/oni/NAOKI PREMIUM.crs
OniList14Color=#E700FF

OniList15Path=Courses/oni/NAOKI STANDARD.crs
OniList15Color=#6B63FF
OniList16Path=Courses/oni/PARANOiA BROTHERS.crs
OniList16Color=#6B63FF
OniList17Path=Courses/oni/NAOKI feat PAULA TERRY.crs
OniList17Color=#6B63FF
OniList18Path=Courses/oni/SOUL 6.crs
OniList18Color=#6B63FF
OniList19Path=Courses/oni/BeForU.crs
OniList19Color=#6B63FF
OniList20Path=Courses/oni/HAPPY HARDCORE.crs
OniList20Color=#6B63FF
OniList21Path=Courses/oni/LOVE RevenG.crs
OniList21Color=#6B63FF
OniList22Path=Courses/oni/FROM SOLO.crs
OniList22Color=#6B63FF
OniList23Path=Courses/oni/MIDNIGHT BLUE.crs
OniList23Color=#6B63FF
OniList24Path=Courses/oni/FROM IIDX.crs
OniList24Color=#6B63FF
OniList25Path=Courses/oni/NAOKI PLATINUM.crs
OniList25Color=#6B63FF
OniList26Path=Courses/oni/Demon Road 2.crs
OniList26Color=#6B63FF

OniList27Path=Courses/oni/IIDX BOSS.crs
OniList27Color=#F70000
OniList28Path=Courses/oni/DEMON'S SLOW ROAD.crs
OniList28Color=#F70000
OniList29Path=Courses/oni/TRUE DEMON ROAD.crs
OniList29Color=#F70000
OniList30Path=Courses/oni/LEGENDARY ROAD.crs
OniList30Color=#F70000

//list of endless courses
EndlessListEnabled=0

[ScreenOptions]
OptionIconsP1X="+rnd.Next(-31, 641)+@"
OptionIconsP1Y="+rnd.Next(-31, 641)+@"
OptionIconsP2X="+rnd.Next(-31, 641)+@"
OptionIconsP2Y="+rnd.Next(-31, 641)+@"
MaxOptionIcon=7
ArrowsX="+rnd.Next(-31, 641)+@"
ColorSelected=1,1,1,1
ColorNotSelected=0.375,0.5,0,1
ColorTitleNotSelected=0.51,0.64,0.06,1
ColorOptionSelectedP1=0.13,0.45,0,1
ColorOptionSelectedP2=0.56,0.35,0,1
ColorOptionSelectedBoth=0.51,0.22,0.22,1
ColorItemBkSelected=0.38,0.45,0.32,1
ColorItemBkNotSelected=0.67,0.807,0.25,1
IconsP1OnCommand=hidden,1
IconsP2OnCommand=hidden,1
ItemsGapX="+rnd.Next(-31, 641)+@"
ItemsSpacingY="+rnd.Next(-31, 641)+@"
ItemsStartX="+rnd.Next(-31, 641)+@"
ItemsEndX="+rnd.Next(-31, 641)+@"
ItemsStartY="+rnd.Next(-31, 641)+@"
ItemsZoom=1
LabelsHAlign=0
LabelsX="+rnd.Next(-31, 641)+@"0
LabelsZoom=1.0
NumShownItems=9
LineHighlightOnCommand=draworder,1
FrameOnCommand=addx,-640;sleep,0.333;decelerate,0.783;addx,640
FrameOffCommand=

[ScreenPlayerOptions]
StyleIcon=1
TimerSeconds="+rnd.Next(2, 100)+@"
DifficultyIconP1X="+rnd.Next(-31, 641)+@"
DifficultyIconP1Y="+rnd.Next(-31, 641)+@"
DifficultyIconP1OnCommand=draworder,2
DifficultyIconP2X="+rnd.Next(-31, 641)+@"
DifficultyIconP2Y="+rnd.Next(-31, 641)+@"
DifficultyIconP2OnCommand=draworder,2
DifficultyIconRow=8
LineNames=1,2,3,4,5,6,7,8
Line1=list,Speed
Line2=list,Accel
Line3=list,Appearance
Line4=list,Turn
//Line5=list,NoteSkins
Line5=list,Other
Line6=list,Scroll
Line7=list,Holds
Line8=Steps
PrevScreen=ScreenBranchSelectSongOrCourse
NextScreen=ScreenBranchGameplay

[ScreenOptionsMaster]
# Player options
Speed="+rnd.Next(2, 7)+@"
SpeedDefault=mod,1x
Speed,1=mod,1x;name,x1
Speed,2=mod,1.5x;name,x1.5
Speed,3=mod,2x;name,x2
Speed,4=mod,3x;name,x3
Speed,5=mod,5x;name,x5
Speed,6=mod,8x;name,x8

Accel="+rnd.Next(2, 3)+@"
AccelDefault=mod,no boost,no brake,no wave,no expand,no boomerang
Accel,1=name,Off
Accel,2=mod,boost;name,On

Appearance="+rnd.Next(2, 5)+@"
AppearanceDefault=mod,no hidden,no sudden,no stealth,no blink,no randomvanish
Appearance,1=name,Visible
Appearance,2=mod,hidden;name,Hidden
Appearance,3=mod,sudden;name,Sudden
Appearance,4=mod,stealth;name,Stealth

Turn="+rnd.Next(2, 6)+@"
TurnDefault=mod,no turn
Turn,1=name,Off
Turn,2=mod,mirror;name,Mirror
Turn,3=mod,left;name,Left
Turn,4=mod,right;name,Right
Turn,5=mod,shuffle;name,Shuffle

Other="+rnd.Next(2, 6)+@"
OtherDefault=mod,no little,no flat,Default,no dark
Other,1=name,Off
Other,2=mod,little;name,Little
Other,3=mod,flat;name,Flat
Other,4=mod,solo;name,Solo
Other,5=mod,dark;name,Dark

Scroll="+rnd.Next(2, 3)+@"
ScrollDefault=mod,no reverse,no split,no alternate,no cross
Scroll,1=name,Standard
Scroll,2=mod,reverse;name,Reverse

Holds="+rnd.Next(2, 3)+@"
HoldsDefault=mod,no noholds,no planted,no twister,no nojumps,no nohands
Holds,1=mod,noholds;name,Off
Holds,2=name,On

Insert="+rnd.Next(2, 3)+@"
InsertDefault=mod,no little,no wide,no big,no quick,no skippy,no echo,no stomp
Insert,1=name,Off
Insert,2=mod,little;name,On

Hide="+rnd.Next(2, 3)+@"
HideDefault=mod,no dark,no blind
Hide,1=name,Off
Hide,2=mod,dark;name,On

[ScreenCoinOptions]
Fallback=ScreenOptionsSubmenu
LineNames=1,2,3,4,5,6
OptionMenuFlags=together;explanations
Line1=conf,CoinMode
Line2=conf,SongsPerPlay
Line3=conf,CoinsPerCredit
Line4=conf,Premium
Line5=conf,EventMode
Line6=conf,ArcadeEventMode

[ScreenBackgroundOptions]
Fallback=ScreenOptionsSubmenu
LineNames=1,2,3,4,5,6,7
OptionMenuFlags=together;explanations
Line1=conf,BackgroundMovies
Line2=conf,BackgroundMode
Line3=conf,Brightness
Line4=conf,Danger
Line5=conf,DancingCharacters
Line6=conf,BeginnerHelper
Line7=conf,RandomBackgrounds

[ScreenBranchGameplay]
Class=ScreenBranch
Choices=1,2,3,4
Condition1=PlayModeName() == "+'"'+"Nonstop"+'"'+@"
Condition2=PlayModeName() == "+'"'+"Oni"+'"'+@"
Condition3=IsExtraStage() or IsExtraStage2()
Condition4=true
NextScreen1=screen,ScreenStageNonstop
NextScreen2=screen,ScreenStageOni
NextScreen3=screen,ScreenStageExtra
NextScreen4=screen,ScreenStage

[ScreenStage]
MinimumDelay=2.2 //1.8 1.9 2 2.3 2.3 2.3 2.5 2.8

[ScreenStageNonstop]
Fallback=ScreenStage
Class=ScreenStage
PrevScreen=ScreenSelectCourse
NextScreen=ScreenGameplayNonstop

[ScreenStageOni]
Fallback=ScreenStage
Class=ScreenStage
PrevScreen=ScreenTitleMenu
NextScreen=ScreenGameplayOni

[Background]
LeftEdge="+rnd.Next(-31, 641)+@"
TopEdge="+rnd.Next(-31, 641)+@"
RightEdge="+rnd.Next(-31, 641)+@"
BottomEdge="+rnd.Next(-31, 641)+@"
BlinkDangerAll="+rnd.Next(1, 2)+@"
DangerAllIsOpaque=1
BrightnessFadeCommand=

[LifeMeterBattery Percent]
PercentP1X="+rnd.Next(-31, 641)+@"
PercentP1Y="+rnd.Next(-31, 641)+@"
PercentP1OnCommand=shadowlength,0;diffuse,#19EFB9
PercentP1OffCommand=
PercentP2X="+rnd.Next(-31, 641)+@"
PercentP2Y="+rnd.Next(-31, 641)+@"
PercentP2OnCommand=shadowlength,0;diffuse,#F8B819
PercentP2OffCommand=
DancePointsP1X="+rnd.Next(-31, 641)+@"
DancePointsP1Y="+rnd.Next(-31, 641)+@"
DancePointsP1OnCommand=shadowlength,0;diffuse,#19EFB9
DancePointsP1OffCommand=
DancePointsP2X="+rnd.Next(-31, 641)+@"
DancePointsP2Y="+rnd.Next(-31, 641)+@"
DancePointsP2OnCommand=shadowlength,0;diffuse,#F8B819
DancePointsP2OffCommand=

[LifeMeterBar]
MeterWidth=256
MeterHeight=16
DangerThreshold=0.25
NumChambers=32
NumStrips=2
NumStripsHot=4

[BeginnerHelper]
Player1_X="+rnd.Next(-31, 641)+@"
Player2_X="+rnd.Next(-31, 641)+@"
PlayerAngle="+rnd.Next(-31, 641)+@"
DancePadAngle="+rnd.Next(-31, 641)+@"
HelperX="+rnd.Next(-31, 641)+@"
HelperY="+rnd.Next(-31, 641)+@"

[Judgment]
MarvelousCommand=shadowlength,0;diffusealpha,1;zoomy,1.8;zoomx,1.1;sleep,0.016;linear,0.033;zoom,1;sleep,0.5;linear,0;diffusealpha,0;glowblink;effectperiod,0.05;effectcolor1,1,1,1,0;effectcolor2,1,1,1,0.8
//on video frames from arcade, the zoomY is clearly around 1.8, maybe even 2. on cs, it's 1.42
PerfectCommand=shadowlength,0;diffusealpha,1;zoomy,1.8;zoomx,1.1;sleep,0.016;linear,0.033;zoom,1;sleep,0.5;linear,0;diffusealpha,0
GreatCommand=shadowlength,0;diffusealpha,1;zoomy,1.2;zoomx,1.1;sleep,0.016;linear,0.033;zoom,1;sleep,0.5;linear,0;diffusealpha,0
GoodCommand=shadowlength,0;diffusealpha,1;zoom,1;sleep,0.533;linear,0;diffusealpha,0
BooCommand=shadowlength,0;diffusealpha,1;zoom,1.0;addx,3;linear,0.066;addx,-6;linear,0.066;addx,6;linear,0.066;addx,-6;linear,0.066;addx,6;linear,0.066;addx,-6;linear,0.066;addx,6;linear,0.066;addx,-6;linear,0.066;addx,6;diffusealpha,0
MissCommand=shadowlength,0;diffusealpha,1;zoom,1;linear,0.533;addy,26

[HoldJudgment]
NGCommand=shadowlength,0;diffusealpha,1;zoom,1;sleep,0.6;diffusealpha,0
OKCommand=shadowlength,0;diffusealpha,1;zoomy,1.5;zoomx,1.2;sleep,0.016;linear,0.033;zoom,1;sleep,0.55;linear,0;diffusealpha,0

[Player]
ReceptorArrowsYStandard="+rnd.Next(-31, 641)+@"
ReceptorArrowsYReverse="+rnd.Next(-31, 641)+@"
JudgmentY="+rnd.Next(-31, 641)+@"
JudgmentYReverse="+rnd.Next(-31, 641)+@"
ComboY="+rnd.Next(-31, 641)+@"
ComboYReverse="+rnd.Next(-31, 641)+@"
HoldJudgmentYStandard="+rnd.Next(-31, 641)+@"
HoldJudgmentYReverse="+rnd.Next(-31, 641)+@"
BrightGhostComboThreshold="+rnd.Next(-31, 641)+@"
StartDrawingAtPixels=-"+rnd.Next(-31, 641)+@"
StopDrawingAtPixels="+rnd.Next(-31, 641)+@"

[Combo]
NumberMaxZoom="+rnd.Next(1, 10)+@"
NumberMaxZoomAt=100
NumberMinZoom="+rnd.Next(1, 5)+@"
PulseZoom="+rnd.Next(1, 5)+@"
ShowComboAt=0
TweenSeconds=0.033

[ScreenGameplay]
DifficultyP1X="+rnd.Next(-31, 641)+@"
DifficultyP1Y="+rnd.Next(-31, 641)+@"
DifficultyP1OnCommand=addz,-100;croptop,0.5;cropbottom,0;addx,-164;linear,0.6;addx,164
DifficultyP1OffCommand=linear,0.8;addx,-164
DifficultyP1ReverseX="+rnd.Next(-31, 641)+@"
DifficultyP1ReverseY="+rnd.Next(-31, 641)+@"
DifficultyP1ReverseOnCommand=croptop,0;cropbottom,0.5;addx,-164;linear,0.6;addx,164
DifficultyP1ReverseOffCommand=linear,0.8;addx,-164
DifficultyP1StageOnCommand=croptop,0.5;cropbottom,0
DifficultyP1ReverseStageOnCommand=croptop,0;cropbottom,0.5
DifficultyP2X="+rnd.Next(-31, 641)+@"
DifficultyP2Y="+rnd.Next(-31, 641)+@"
DifficultyP2OnCommand=croptop,0.5;cropbottom,0;addx,164;linear,0.6;addx,-164
DifficultyP2OffCommand=linear,0.8;addx,164
DifficultyP2ReverseX="+rnd.Next(-31, 641)+@"
DifficultyP2ReverseY="+rnd.Next(-31, 641)+@"
DifficultyP2ReverseOnCommand=croptop,0;cropbottom,0.5;addx,164;linear,0.6;addx,-164
DifficultyP2ReverseOffCommand=linear,0.8;addx,164
DifficultyP2StageOnCommand=croptop,0.5;cropbottom,0
DifficultyP2ReverseStageOnCommand=croptop,0;cropbottom,0.5
LifeFrameX="+rnd.Next(-31, 641)+@"
LifeFrameY="+rnd.Next(-31, 641)+@"
LifeFrameOnCommand=addy,-50;linear,0.6;addy,50
LifeFrameOffCommand=linear,0.8;addy,-50
LifeP1X="+rnd.Next(-31, 641)+@"
LifeP1Y="+rnd.Next(-31, 641)+@"
LifeP1OnCommand=addy,-50;linear,0.6;addy,50
LifeP1OffCommand=addy,999
LifeP2X="+rnd.Next(-31, 641)+@"
LifeP2Y="+rnd.Next(-31, 641)+@"
LifeP2OnCommand=addy,-50;linear,0.6;addy,50
LifeP2OffCommand=addy,999
PlayerOptionsP1X="+rnd.Next(-31, 641)+@"
PlayerOptionsP1Y="+rnd.Next(-31, 641)+@"
PlayerOptionsP1OnCommand=horizalign,left;diffuse,#1FEFB6;addy,78;linear,0.6;addy,-78
PlayerOptionsP1OffCommand=linear,0.8;addy,78
PlayerOptionsP2X="+rnd.Next(-31, 641)+@"
PlayerOptionsP2Y="+rnd.Next(-31, 641)+@"
PlayerOptionsP2OnCommand=horizalign,left;diffuse,#F1A516;addy,78;linear,0.6;addy,-78
PlayerOptionsP2OffCommand=linear,0.8;addy,78
ScoreFrameX="+rnd.Next(-31, 641)+@"
ScoreFrameY="+rnd.Next(-31, 641)+@"
ScoreFrameOnCommand=addy,78;linear,0.6;addy,-78
ScoreFrameOffCommand=linear,0.8;addy,78
ScoreP1X="+rnd.Next(-31, 641)+@"
ScoreP1Y="+rnd.Next(-31, 641)+@"
ScoreP1OnCommand=draworder,11;addy,78;linear,0.6;addy,-78
ScoreP1OffCommand=linear,0.8;addy,78
ScoreP2X="+rnd.Next(-31, 641)+@"
ScoreP2Y="+rnd.Next(-31, 641)+@"
ScoreP2OnCommand=draworder,11;addy,78;linear,0.6;addy,-78
ScoreP2OffCommand=linear,0.8;addy,78
StageX="+rnd.Next(-31, 641)+@"
StageY="+rnd.Next(-31, 641)+@"
StageOnCommand=addy,-50;linear,0.6;addy,50
StageOffCommand=linear,0.8;addy,-50
StageFrameX="+rnd.Next(-31, 641)+@"
StageFrameY="+rnd.Next(-31, 641)+@"
StageFrameOnCommand=
SongOptionsOnCommand=hidden,1
SoloNoteSkinQuirk=1


[ScreenGameplayExtra]
DifficultyP1ReverseX="+rnd.Next(-31, 641)+@"
DifficultyP1ReverseY="+rnd.Next(-31, 641)+@"9
DifficultyP1ReverseOnCommand=croptop,0;cropbottom,0.5;addx,-164;linear,0.6;addx,164
DifficultyP1ReverseOffCommand=linear,0.8;addx,-164
DifficultyP2ReverseX="+rnd.Next(-31, 641)+@"
DifficultyP2ReverseY="+rnd.Next(-31, 641)+@"
DifficultyP2ReverseOnCommand=croptop,0;cropbottom,0.5;addx,164;linear,0.6;addx,-164
DifficultyP2ReverseOffCommand=linear,0.8;addx,164
LifeFrameX="+rnd.Next(-31, 641)+@"
LifeFrameY="+rnd.Next(-31, 641)+@"
LifeFrameOnCommand=addy,78;linear,0.6;addy,-78
LifeFrameOffCommand=linear,0.8;addy,78
LifeP1X="+rnd.Next(-31, 641)+@"
LifeP1Y="+rnd.Next(-31, 641)+@"
LifeP1OnCommand=addy,78;linear,0.6;addy,-78
LifeP1OffCommand=addy,999
LifeP2X="+rnd.Next(-31, 641)+@"
LifeP2Y="+rnd.Next(-31, 641)+@"
LifeP2OnCommand=addy,78;linear,0.6;addy,-78
LifeP2OffCommand=addy,999
ScoreFrameX="+rnd.Next(-31, 641)+@"
ScoreFrameY="+rnd.Next(-31, 641)+@"
ScoreFrameOnCommand=addy,-50;linear,0.6;addy,50
ScoreFrameOffCommand=linear,0.8;addy,-50
PlayerOptionsP1X="+rnd.Next(-31, 641)+@"
PlayerOptionsP1Y="+rnd.Next(-31, 641)+@"
PlayerOptionsP1OnCommand=horizalign,left;diffuse,#1FEFB6;addy,-50;linear,0.6;addy,50
PlayerOptionsP1OffCommand=linear,0.8;addy,-50
PlayerOptionsP2X="+rnd.Next(-31, 641)+@"
PlayerOptionsP2Y="+rnd.Next(-31, 641)+@"
PlayerOptionsP2OnCommand=horizalign,left;diffuse,#F1A516;addy,-50;linear,0.6;addy,50
PlayerOptionsP2OffCommand=linear,0.8;addy,-50
SongOptionsOnCommand=hidden,1
ScoreP1X="+rnd.Next(-31, 641)+@"
ScoreP1Y="+rnd.Next(-31, 641)+@"
ScoreP1OnCommand=addy,-50;linear,0.6;addy,50
ScoreP1OffCommand=linear,0.8;addy,-50
ScoreP2X="+rnd.Next(-31, 641)+@"
ScoreP2Y="+rnd.Next(-31, 641)+@"
ScoreP2OnCommand=addy,-50;linear,0.6;addy,50
ScoreP2OffCommand=linear,0.8;addy,-50
StageX="+rnd.Next(-31, 641)+@"
StageY="+rnd.Next(-31, 641)+@"
StageOnCommand=addy,78;linear,0.6;addy,-78
StageOffCommand=linear,0.8;addy,78
StageFrameX="+rnd.Next(-31, 641)+@"
StageFrameY="+rnd.Next(-31, 641)+@"
StageFrameOnCommand=hidden,1

[ScreenGameplayNonstop]
Fallback=ScreenGameplay
Class=ScreenGameplay
PrevScreen=ScreenSelectCourse
ShowEvaluationOnFail=1

[ScreenGameplayOni]
Class=ScreenGameplay
Fallback=ScreenGameplay
PrevScreen=ScreenSelectCourseOni
ShowEvaluationOnFail=1
LifeP1OffCommand=linear,0.8;addy,-50
LifeP1OnCommand=diffuse,#19F1BA;draworder,11;addy,-50;linear,0.6;addy,50
LifeP1X="+rnd.Next(-31, 641)+@"
LifeP1Y="+rnd.Next(-31, 641)+@"
LifeP2OffCommand=linear,0.8;addy,-50
LifeP2OnCommand=diffuse,#FAB919;draworder,11;addy,-50;linear,0.6;addy,50
LifeP2X="+rnd.Next(-31, 641)+@"
LifeP2Y="+rnd.Next(-31, 641)+@"
LifeColorP1X="+rnd.Next(-31, 641)+@"
LifeColorP1Y="+rnd.Next(-31, 641)+@"
LifeColorP1OffCommand=addy,-999
LifeColorP1OnCommand=draworder,10;addy,-999;sleep,0.6;addy,999
LifeColorP2X="+rnd.Next(-31, 641)+@"
LifeColorP2Y="+rnd.Next(-31, 641)+@"
LifeColorP2OffCommand=addy,-999
LifeColorP2OnCommand=draworder,10;addy,-999;sleep,0.6;addy,999
SongNumberP1OffCommand=linear,0.8;addy,-50
SongNumberP1OnCommand=diffuse,1,1,1,1;draworder,11;addy,-50;linear,0.6;addy,50
SongNumberP1X="+rnd.Next(-31, 641)+@"
SongNumberP1Y="+rnd.Next(-31, 641)+@"
SongNumberP2OffCommand=linear,0.8;addy,-50
SongNumberP2OnCommand=diffuse,1,1,1,1;draworder,11;addy,-50;linear,0.6;addy,50
SongNumberP2X="+rnd.Next(-31, 641)+@"
SongNumberP2Y="+rnd.Next(-31, 641)+@"
ScoreP1X="+rnd.Next(-31, 641)+@"
ScoreP2X="+rnd.Next(-31, 641)+@"

[ScreenGameplayNonstop DifficultyMeterP1]
Fallback=DifficultyMeter

[ScreenGameplayNonstop DifficultyMeterP2]
Fallback=DifficultyMeter

[ScreenGameplayOni DifficultyMeterP1]
Fallback=DifficultyMeter

[ScreenGameplayOni DifficultyMeterP2]
Fallback=DifficultyMeter

[ScreenEvaluation]
TimerSeconds="+rnd.Next(2, 100)+@"
StyleIcon=0
MemoryCardIcons=0
MarvelousLabelX="+rnd.Next(-31, 641)+@"
MarvelousLabelY="+rnd.Next(-31, 641)+@"
MarvelousLabelOnCommand=addy,316;sleep,0.250;decelerate,0.2;addy,-316
MarvelousLabelOffCommand=sleep,0.550;accelerate,0.150;addy,316
MarvelousNumberP1X="+rnd.Next(-31, 641)+@"
MarvelousNumberP1Y="+rnd.Next(-31, 641)+@"
MarvelousNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.266;decelerate,0.183;addx,260
MarvelousNumberP1OffCommand=sleep,0.550;accelerate,0.183;addx,-260
MarvelousNumberP2X="+rnd.Next(-31, 641)+@"
MarvelousNumberP2Y="+rnd.Next(-31, 641)+@"
MarvelousNumberP2OnCommand=horizalign,left;addx,260;sleep,0.266;decelerate,0.183;addx,-260
MarvelousNumberP2OffCommand=sleep,0.550;accelerate,0.183;addx,260
PerfectLabelX="+rnd.Next(-31, 641)+@"
PerfectLabelY="+rnd.Next(-31, 641)+@"
PerfectLabelOnCommand=addy,316;sleep,0.316;decelerate,0.2;addy,-316
PerfectLabelOffCommand=sleep,0.483;accelerate,0.150;addy,316
PerfectNumberP1X="+rnd.Next(-31, 641)+@"
PerfectNumberP1Y="+rnd.Next(-31, 641)+@"
PerfectNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.333;decelerate,0.183;addx,260
PerfectNumberP1OffCommand=sleep,0.483;accelerate,0.183;addx,-260
PerfectNumberP2X="+rnd.Next(-31, 641)+@"
PerfectNumberP2Y="+rnd.Next(-31, 641)+@"
PerfectNumberP2OnCommand=horizalign,left;addx,260;sleep,0.333;decelerate,0.183;addx,-260
PerfectNumberP2OffCommand=sleep,0.483;accelerate,0.183;addx,260
GreatLabelX="+rnd.Next(-31, 641)+@"
GreatLabelY="+rnd.Next(-31, 641)+@"
GreatLabelOnCommand=addy,316;sleep,0.383;decelerate,0.2;addy,-316
GreatLabelOffCommand=sleep,0.416;accelerate,0.150;addy,316
GreatNumberP1X="+rnd.Next(-31, 641)+@"
GreatNumberP1Y="+rnd.Next(-31, 641)+@"
GreatNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.400;decelerate,0.183;addx,260
GreatNumberP1OffCommand=sleep,0.416;accelerate,0.183;addx,-260
GreatNumberP2X="+rnd.Next(-31, 641)+@"
GreatNumberP2Y="+rnd.Next(-31, 641)+@"
GreatNumberP2OnCommand=horizalign,left;addx,260;sleep,0.400;decelerate,0.183;addx,-260
GreatNumberP2OffCommand=sleep,0.416;accelerate,0.183;addx,260
GoodLabelX="+rnd.Next(-31, 641)+@"
GoodLabelY="+rnd.Next(-31, 641)+@"
GoodLabelOnCommand=addy,316;sleep,0.450;decelerate,0.2;addy,-316
GoodLabelOffCommand=sleep,0.350;accelerate,0.150;addy,316
GoodNumberP1X="+rnd.Next(-31, 641)+@"
GoodNumberP1Y="+rnd.Next(-31, 641)+@"
GoodNumberP1OffCommand=sleep,0.350;accelerate,0.183;addx,-260
GoodNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.466;decelerate,0.183;addx,260
GoodNumberP2X="+rnd.Next(-31, 641)+@"
GoodNumberP2Y="+rnd.Next(-31, 641)+@"
GoodNumberP2OnCommand=horizalign,left;addx,260;sleep,0.466;decelerate,0.183;addx,-260
GoodNumberP2OffCommand=sleep,0.350;accelerate,0.183;addx,260
BooLabelX="+rnd.Next(-31, 641)+@"
BooLabelY="+rnd.Next(-31, 641)+@"
BooLabelOnCommand=addy,316;sleep,0.516;decelerate,0.2;addy,-316
BooLabelOffCommand=sleep,0.283;accelerate,0.150;addy,316
BooNumberP1X="+rnd.Next(-31, 641)+@"
BooNumberP1Y="+rnd.Next(-31, 641)+@"
BooNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.533;decelerate,0.183;addx,260
BooNumberP1OffCommand=sleep,0.283;accelerate,0.183;addx,-260
BooNumberP2X="+rnd.Next(-31, 641)+@"
BooNumberP2Y="+rnd.Next(-31, 641)+@"
BooNumberP2OnCommand=horizalign,left;addx,260;sleep,0.533;decelerate,0.183;addx,-260
BooNumberP2OffCommand=sleep,0.283;accelerate,0.183;addx,260
MissLabelX="+rnd.Next(-31, 641)+@"
MissLabelY="+rnd.Next(-31, 641)+@"
MissLabelOnCommand=addy,316;sleep,0.583;decelerate,0.2;addy,-316
MissLabelOffCommand=sleep,0.216;accelerate,0.150;addy,316
MissNumberP1X="+rnd.Next(-31, 641)+@"
MissNumberP1Y="+rnd.Next(-31, 641)+@"
MissNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.600;decelerate,0.183;addx,260
MissNumberP1OffCommand=sleep,0.216;accelerate,0.183;addx,-260
MissNumberP2X="+rnd.Next(-31, 641)+@"
MissNumberP2Y="+rnd.Next(-31, 641)+@"
MissNumberP2OnCommand=horizalign,left;addx,260;sleep,0.600;decelerate,0.183;addx,-260
MissNumberP2OffCommand=sleep,0.216;accelerate,0.183;addx,260
OKLabelX="+rnd.Next(-31, 641)+@"
OKLabelY="+rnd.Next(-31, 641)+@"
OKLabelOnCommand=addy,316;sleep,0.650;decelerate,0.2;addy,-316
OKLabelOffCommand=sleep,0.150;accelerate,0.150;addy,316
OKNumberP1X="+rnd.Next(-31, 641)+@"
OKNumberP1Y="+rnd.Next(-31, 641)+@"
OKNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.666;decelerate,0.183;addx,260
OKNumberP1OffCommand=sleep,0.150;accelerate,0.183;addx,-260
OKNumberP2X="+rnd.Next(-31, 641)+@"
OKNumberP2Y="+rnd.Next(-31, 641)+@"
OKNumberP2OnCommand=horizalign,left;addx,260;sleep,0.666;decelerate,0.183;addx,-260
OKNumberP2OffCommand=sleep,0.150;accelerate,0.183;addx,260
BannerHeight="+rnd.Next(-31, 641)+@"
BannerWidth="+rnd.Next(-31, 641)+@"

LargeBannerX="+rnd.Next(-31, 641)+@"
LargeBannerY="+rnd.Next(-31, 641)+@"
LargeBannerOnCommand=addy,410;sleep,0.266;decelerate,0.133;addy,-410
LargeBannerOffCommand=sleep,0.6;accelerate,0.150;addy,410
LargeBannerFrameX="+rnd.Next(-31, 641)+@"
LargeBannerFrameY="+rnd.Next(-31, 641)+@"
LargeBannerFrameOnCommand=addy,410;sleep,0.266;decelerate,0.133;addy,-410
LargeBannerFrameOffCommand=sleep,0.6;accelerate,0.150;addy,410
PlayerOptionsP1OffCommand=sleep,0.6;accelerate,0.150;addy,410
PlayerOptionsP1OnCommand=shadowlength,0;horizalign,left;addy,410;sleep,0.266;decelerate,0.133;addy,-410
PlayerOptionsP1X="+rnd.Next(-31, 641)+@"
PlayerOptionsP1Y="+rnd.Next(-31, 641)+@"
PlayerOptionsP2OffCommand=sleep,0.6;accelerate,0.150;addy,410
PlayerOptionsP2OnCommand=shadowlength,0;addy,410;sleep,0.266;decelerate,0.133;addy,-410;horizalign,right
PlayerOptionsP2X="+rnd.Next(-31, 641)+@"
PlayerOptionsP2Y="+rnd.Next(-31, 641)+@"
PlayerOptionsSeparator= 
StageX="+rnd.Next(-31, 641)+@"
StageY="+rnd.Next(-31, 641)+@"
StageOffCommand=sleep,0.6;accelerate,0.150;addy,410
StageOnCommand=addy,410;sleep,0.266;decelerate,0.133;addy,-410
DifficultyIconP1X="+rnd.Next(-31, 641)+@"
DifficultyIconP1Y="+rnd.Next(-31, 641)+@"
DifficultyIconP1OffCommand=sleep,0.6;addy,999
DifficultyIconP1OnCommand=addy,999;sleep,0.4;addy,-999
DifficultyIconP2X="+rnd.Next(-31, 641)+@"
DifficultyIconP2Y="+rnd.Next(-31, 641)+@"
DifficultyIconP2OffCommand=sleep,0.6;addy,999
DifficultyIconP2OnCommand=addy,999;sleep,0.4;addy,-999
GradeFrameP1X="+rnd.Next(-31, 641)+@"
GradeFrameP1Y="+rnd.Next(-31, 641)+@"
GradeFrameP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
GradeFrameP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
GradeFrameP2X="+rnd.Next(-31, 641)+@"
GradeFrameP2Y="+rnd.Next(-31, 641)+@"
GradeFrameP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
GradeFrameP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
GradeP1X="+rnd.Next(-31, 641)+@"
GradeP1Y="+rnd.Next(-31, 641)+@"
GradeP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
GradeP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
GradeP2X="+rnd.Next(-31, 641)+@"
GradeP2Y="+rnd.Next(-31, 641)+@"
GradeP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
GradeP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
Grade2P1X="+rnd.Next(-31, 641)+@"
Grade2P1Y="+rnd.Next(-31, 641)+@"
Grade2P1OnCommand=addy,999;sleep,3;addy,-999;diffuseshift;blend,add;effectcolor1,1,1,1,0.3;effectcolor2,1,1,1,0;effectperiod,0.396
Grade2P1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
Grade2P2X="+rnd.Next(-31, 641)+@"
Grade2P2Y="+rnd.Next(-31, 641)+@"    
Grade2P2OnCommand=addy,999;sleep,3;addy,-999;diffuseshift;blend,add;effectcolor1,1,1,1,0.3;effectcolor2,1,1,1,0;effectperiod,0.396
Grade2P2OffCommand=sleep,0.6;accelerate,0.150;addx,172
PercentFrameP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
PercentFrameP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
PercentFrameP1X="+rnd.Next(-31, 641)+@"
PercentFrameP1Y="+rnd.Next(-31, 641)+@"
PercentFrameP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
PercentFrameP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
PercentFrameP2X="+rnd.Next(-31, 641)+@"
PercentFrameP2Y="+rnd.Next(-31, 641)+@"
PercentP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
PercentP1OnCommand=horizalign,center;addx,-172;sleep,0.250;decelerate,0.150;addx,172
PercentP1X="+rnd.Next(-31, 641)+@"
PercentP1Y="+rnd.Next(-31, 641)+@"
PercentP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
PercentP2OnCommand=horizalign,center;addx,172;sleep,0.250;decelerate,0.150;addx,-172
PercentP2X="+rnd.Next(-31, 641)+@"
PercentP2Y="+rnd.Next(-31, 641)+@"
BonusFrameP1X="+rnd.Next(-31, 641)+@"
BonusFrameP1Y="+rnd.Next(-31, 641)+@"
BonusFrameP1OnCommand=diffusealpha,0;sleep,0.65;diffusealpha,1
BonusFrameP1OffCommand=sleep,0.333;diffusealpha,0
BonusFrameP2X="+rnd.Next(-31, 641)+@"
BonusFrameP2Y="+rnd.Next(-31, 641)+@"
BonusFrameP2OnCommand=diffusealpha,0;sleep,0.65;diffusealpha,1
BonusFrameP2OffCommand=sleep,0.333;diffusealpha,0
ShowGraphArea=1
GraphStartHeight=0
GraphFrameP1X="+rnd.Next(-31, 641)+@"
GraphFrameP1Y="+rnd.Next(-31, 641)+@"
GraphFrameP1OnCommand=blend,add;diffusealpha,0;sleep,0.25;linear,0.4;diffusealpha,1;sleep,0;diffusealpha,0
GraphFrameP1OffCommand=sleep,0.333;diffusealpha,1;linear,0.366;diffusealpha,0;sleep,0;addy,999
GraphFrameP2X="+rnd.Next(-31, 641)+@"
GraphFrameP2Y="+rnd.Next(-31, 641)+@"
GraphFrameP2OnCommand=blend,add;diffusealpha,0;sleep,0.25;linear,0.4;diffusealpha,1;sleep,0;diffusealpha,0
GraphFrameP2OffCommand=sleep,0.333;diffusealpha,1;linear,0.366;diffusealpha,0;sleep,0;addy,999
GraphP1X=
GraphP1Y=
GraphP1OnCommand=hidden,1
GraphP1OffCommand=
GraphP2X=
GraphP2Y=
GraphP2OnCommand=hidden,1
GraphP2OffCommand=
SurvivedFrameP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
SurvivedFrameP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
SurvivedFrameP1X="+rnd.Next(-31, 641)+@"
SurvivedFrameP1Y="+rnd.Next(-31, 641)+@"
SurvivedFrameP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
SurvivedFrameP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
SurvivedFrameP2X="+rnd.Next(-31, 641)+@"
SurvivedFrameP2Y="+rnd.Next(-31, 641)+@"
SurvivedNumberP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
SurvivedNumberP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
SurvivedNumberP1X="+rnd.Next(-31, 641)+@"
SurvivedNumberP1Y="+rnd.Next(-31, 641)+@"
SurvivedNumberP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
SurvivedNumberP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
SurvivedNumberP2X="+rnd.Next(-31, 641)+@"
SurvivedNumberP2Y="+rnd.Next(-31, 641)+@"
PercentBarActualP1X="+rnd.Next(-31, 641)+@"
PercentBarActualP1Y="+rnd.Next(-31, 641)+@"
PercentBarActualP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
PercentBarActualP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
PercentBarActualP2X="+rnd.Next(-31, 641)+@"
PercentBarActualP2Y="+rnd.Next(-31, 641)+@"
PercentBarActualP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
PercentBarActualP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
PercentBarPossibleP1X="+rnd.Next(-31, 641)+@"
PercentBarPossibleP1Y="+rnd.Next(-31, 641)+@"
PercentBarPossibleP1OffCommand=sleep,0.6;accelerate,0.150;addx,-172
PercentBarPossibleP1OnCommand=addx,-172;sleep,0.250;decelerate,0.150;addx,172
PercentBarPossibleP2X="+rnd.Next(-31, 641)+@"
PercentBarPossibleP2Y="+rnd.Next(-31, 641)+@"
PercentBarPossibleP2OffCommand=sleep,0.6;accelerate,0.150;addx,172
PercentBarPossibleP2OnCommand=addx,172;sleep,0.250;decelerate,0.150;addx,-172
BarPossible1P1X="+rnd.Next(-31, 641)+@"
BarPossible1P1Y="+rnd.Next(-31, 641)+@"
BarPossible1P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.2;linear,1.0;zoomx,1
BarPossible1P1OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible1P2X="+rnd.Next(-31, 641)+@"
BarPossible1P2Y="+rnd.Next(-31, 641)+@"
BarPossible1P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.2;linear,1.0;zoomx,1
BarPossible1P2OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible2P1X="+rnd.Next(-31, 641)+@"
BarPossible2P1Y="+rnd.Next(-31, 641)+@"
BarPossible2P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.3;linear,1.0;zoomx,1
BarPossible2P1OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible2P2X="+rnd.Next(-31, 641)+@"
BarPossible2P2Y="+rnd.Next(-31, 641)+@"
BarPossible2P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.3;linear,1.0;zoomx,1
BarPossible2P2OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible3P1X="+rnd.Next(-31, 641)+@"
BarPossible3P1Y="+rnd.Next(-31, 641)+@"
BarPossible3P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.4;linear,1.0;zoomx,1
BarPossible3P1OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible3P2X="+rnd.Next(-31, 641)+@"
BarPossible3P2Y="+rnd.Next(-31, 641)+@"
BarPossible3P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.4;linear,1.0;zoomx,1
BarPossible3P2OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible4P1X="+rnd.Next(-31, 641)+@"
BarPossible4P1Y="+rnd.Next(-31, 641)+@"
BarPossible4P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,1.0;linear,1.0;zoomx,1
BarPossible4P1OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible4P2X="+rnd.Next(-31, 641)+@"
BarPossible4P2Y="+rnd.Next(-31, 641)+@"
BarPossible4P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,1.0;linear,1.0;zoomx,1
BarPossible4P2OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible5P1X="+rnd.Next(-31, 641)+@"
BarPossible5P1Y="+rnd.Next(-31, 641)+@"
BarPossible5P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.6;linear,1.0;zoomx,1
BarPossible5P1OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarPossible5P2X="+rnd.Next(-31, 641)+@"
BarPossible5P2Y="+rnd.Next(-31, 641)+@"
BarPossible5P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.6;linear,1.0;zoomx,1
BarPossible5P2OffCommand=sleep,0.333;linear,0.366;diffusealpha,0
BarActual1P1X="+rnd.Next(-31, 641)+@"
BarActual1P1Y="+rnd.Next(-31, 641)+@"
BarActual1P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.7;linear,1.0;zoomx,1
BarActual1P1OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual1P2X="+rnd.Next(-31, 641)+@"
BarActual1P2Y="+rnd.Next(-31, 641)+@"
BarActual1P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.7;linear,1.0;zoomx,1
BarActual1P2OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual2P1X="+rnd.Next(-31, 641)+@"
BarActual2P1Y="+rnd.Next(-31, 641)+@"
BarActual2P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.8;linear,1.0;zoomx,1
BarActual2P1OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual2P2X="+rnd.Next(-31, 641)+@"
BarActual2P2Y=2"+rnd.Next(-31, 641)+@"17
BarActual2P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.8;linear,1.0;zoomx,1
BarActual2P2OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual3P1X="+rnd.Next(-31, 641)+@"
BarActual3P1Y="+rnd.Next(-31, 641)+@"
BarActual3P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,0.9;linear,1.0;zoomx,1
BarActual3P1OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual3P2X="+rnd.Next(-31, 641)+@"
BarActual3P2Y="+rnd.Next(-31, 641)+@"
BarActual3P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,0.9;linear,1.0;zoomx,1
BarActual3P2OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual4P1X="+rnd.Next(-31, 641)+@"
BarActual4P1Y="+rnd.Next(-31, 641)+@"
BarActual4P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,1.0;linear,1.0;zoomx,1
BarActual4P1OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual4P2X="+rnd.Next(-31, 641)+@"
BarActual4P2Y="+rnd.Next(-31, 641)+@"
BarActual4P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,1.0;linear,1.0;zoomx,1
BarActual4P2OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual5P1X="+rnd.Next(-31, 641)+@"
BarActual5P1Y="+rnd.Next(-31, 641)+@"
BarActual5P1OnCommand=horizalign,left;rotationz,180;zoomx,0;sleep,1.1;linear,1.0;zoomx,1
BarActual5P1OffCommand=stopeffect;sleep,0.333;linear,0.366;diffusealpha,0
BarActual5P2X="+rnd.Next(-31, 641)+@"
BarActual5P2Y="+rnd.Next(-31, 641)+@"
BarActual5P2OnCommand=horizalign,left;rotationz,0;zoomx,0;sleep,1.1;linear,1.0;zoomx,1
BarActual5P2OffCommand=stopeffect;linear,0.7;diffusealpha,0
BarActualMaxCommand=glowshift;effectcolor1,0,0,0,0.35;effectcolor2,1,1,1,0.2;effectperiod,0.5
BarActualAllMaxCommand=glowshift;effectcolor1,0,0,0,0.35;effectcolor2,1,1,1,0.2;effectperiod,0.25
MaxComboNumberP1X="+rnd.Next(-31, 641)+@"
MaxComboNumberP1Y="+rnd.Next(-31, 641)+@"
MaxComboNumberP1OffCommand=sleep,0.333;stopeffect;linear,0.3;diffusealpha,0
MaxComboNumberP1OnCommand=diffuse,#F8F800;diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1
MaxComboNumberP2X="+rnd.Next(-31, 641)+@"
MaxComboNumberP2Y="+rnd.Next(-31, 641)+@"
MaxComboNumberP2OffCommand=sleep,0.333;stopeffect;linear,0.3;diffusealpha,0
MaxComboNumberP2OnCommand=diffuse,#F8F800;diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1
MaxComboMaxCommand=diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1;diffuseshift;effectcolor1,1,1,0,0;effectcolor2,1,1,0,1;effectperiod,0.5
MaxComboAllMaxCommand=diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1;diffuseshift;effectcolor1,1,1,0,0;effectcolor2,1,1,0,1;effectperiod,0.25
MaxCombo2NumberP1X="+rnd.Next(-31, 641)+@"
MaxCombo2NumberP1Y="+rnd.Next(-31, 641)+@"
MaxCombo2NumberP1OffCommand=sleep,0.333;linear,0.3;diffusealpha,0
MaxCombo2NumberP1OnCommand=diffuse,#F8F800;diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1
MaxCombo2NumberP2X="+rnd.Next(-31, 641)+@"
MaxCombo2NumberP2Y="+rnd.Next(-31, 641)+@"
MaxCombo2NumberP2OffCommand=sleep,0.333;linear,0.3;diffusealpha,0
MaxCombo2NumberP2OnCommand=diffuse,#F8F800;diffusealpha,0;sleep,0.366;linear,0.3;diffusealpha,1
ScoreLabelX="+rnd.Next(-31, 641)+@"
ScoreLabelY="+rnd.Next(-31, 641)+@"
ScoreLabelOffCommand=sleep,0.016;accelerate,0.116;addy,138
ScoreLabelOnCommand=addy,138;sleep,0.866;decelerate,0.116;addy,-138
ScoreNumberP1X="+rnd.Next(-31, 641)+@"
ScoreNumberP1Y="+rnd.Next(-31, 641)+@"
ScoreNumberP1OffCommand=sleep,0.016;accelerate,0.183;addx,-260
ScoreNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.8;decelerate,0.183;addx,260
ScoreNumberP2X="+rnd.Next(-31, 641)+@"
ScoreNumberP2Y="+rnd.Next(-31, 641)+@"
ScoreNumberP2OffCommand=sleep,0.016;accelerate,0.183;addx,260
ScoreNumberP2OnCommand=horizalign,left;addx,260;sleep,0.8;decelerate,0.183;addx,-260
TimeLabelX="+rnd.Next(-31, 641)+@"
TimeLabelY="+rnd.Next(-31, 641)+@"
TimeLabelOffCommand=sleep,0.016;accelerate,0.116;addy,138
TimeLabelOnCommand=addy,138;sleep,0.866;decelerate,0.116;addy,-138
TimeNumberP1X="+rnd.Next(-31, 641)+@"
TimeNumberP1Y="+rnd.Next(-31, 641)+@"
TimeNumberP1OffCommand=sleep,0.016;accelerate,0.183;addx,-260
TimeNumberP1OnCommand=horizalign,right;addx,-260;sleep,0.8;decelerate,0.183;addx,260
TimeNumberP2X="+rnd.Next(-31, 641)+@"
TimeNumberP2Y="+rnd.Next(-31, 641)+@"
TimeNumberP2OffCommand=sleep,0.016;accelerate,0.183;addx,260
TimeNumberP2OnCommand=horizalign,left;addx,260;sleep,0.8;decelerate,0.183;addx,-260
SmallBanner1X="+rnd.Next(-31, 641)+@"
SmallBanner1Y="+rnd.Next(-31, 641)+@"
SmallBanner1OnCommand=zoomx,0.52;zoomy,0.55;zoomy,0.56;addy,440;sleep,0.3;decelerate,0.1;addy,-440
SmallBanner1OffCommand=sleep,0.666;accelerate,0.1;addy,440
SmallBanner2X="+rnd.Next(-31, 641)+@"
SmallBanner2Y="+rnd.Next(-31, 641)+@"
SmallBanner2OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.316;decelerate,0.1;addy,-440
SmallBanner2OffCommand=sleep,0.650;accelerate,0.1;addy,440
SmallBanner3X="+rnd.Next(-31, 641)+@"
SmallBanner3Y="+rnd.Next(-31, 641)+@"
SmallBanner3OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.333;decelerate,0.1;addy,-440
SmallBanner3OffCommand=sleep,0.633;accelerate,0.1;addy,440
SmallBanner4X="+rnd.Next(-31, 641)+@"
SmallBanner4Y="+rnd.Next(-31, 641)+@"
SmallBanner4OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.350;decelerate,0.1;addy,-440
SmallBanner4OffCommand=sleep,0.616;accelerate,0.1;addy,440
SmallBanner5X="+rnd.Next(-31, 641)+@"
SmallBanner5Y="+rnd.Next(-31, 641)+@"
SmallBanner5OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.366;decelerate,0.1;addy,-440
SmallBanner5OffCommand=sleep,0.6;accelerate,0.1;addy,440
SmallBanner6Y=129
SmallBanner6OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.383;decelerate,0.1;addy,-440
SmallBanner6OffCommand=sleep,0.583;accelerate,0.1;addy,440
SmallBanner7Y=129
SmallBanner7OnCommand=zoomx,0.52;zoomy,0.55;addy,440;sleep,0.400;decelerate,0.1;addy,-440
SmallBanner7OffCommand=sleep,0.566;accelerate,0.1;addy,440
TryExtraStageOffCommand=sleep,0.750;diffusealpha,0
TryExtraStageOnCommand=addx,482;sleep,1.023;decelerate,0.520;addx,-482;glowshift;effectperiod,0.4;effectcolor1,0,0,0,0;effectcolor2,0,0,0,0.3
TryExtraStageX="+rnd.Next(-31, 641)+@"
TryExtraStageY="+rnd.Next(-31, 641)+@"

[ScreenEvaluation Percent]
DancePointsP1X="+rnd.Next(-31, 641)+@"
DancePointsP1Y="+rnd.Next(-31, 641)+@"
DancePointsP1OnCommand=shadowlength,0
DancePointsP1OffCommand=
DancePointsP2X="+rnd.Next(-31, 641)+@"
DancePointsP2Y="+rnd.Next(-31, 641)+@"
DancePointsP2OnCommand=shadowlength,0
DancePointsP2OffCommand=


[ScreenEvaluationMarvelous]
Fallback=ScreenEvaluation
MarvelousLabelY="+rnd.Next(-31, 641)+@"
MarvelousNumberP1Y="+rnd.Next(-31, 641)+@"
MarvelousNumberP2Y="+rnd.Next(-31, 641)+@"
PerfectLabelY="+rnd.Next(-31, 641)+@"
PerfectNumberP1Y="+rnd.Next(-31, 641)+@"
PerfectNumberP2Y="+rnd.Next(-31, 641)+@"
GreatLabelY="+rnd.Next(-31, 641)+@"
GreatNumberP1Y="+rnd.Next(-31, 641)+@"
GreatNumberP2Y="+rnd.Next(-31, 641)+@"
GoodLabelY="+rnd.Next(-31, 641)+@"
GoodNumberP1Y="+rnd.Next(-31, 641)+@"
GoodNumberP2Y="+rnd.Next(-31, 641)+@"
BooLabelY="+rnd.Next(-31, 641)+@"
BooNumberP1Y="+rnd.Next(-31, 641)+@"
BooNumberP2Y="+rnd.Next(-31, 641)+@"
MissLabelY="+rnd.Next(-31, 641)+@"
MissNumberP1Y="+rnd.Next(-31, 641)+@"
MissNumberP2Y="+rnd.Next(-31, 641)+@"
OKLabelY="+rnd.Next(-31, 641)+@"
OKNumberP1Y="+rnd.Next(-31, 641)+@"
OKNumberP2Y="+rnd.Next(-31, 641)+@"

[ScreenEvaluationNoMarvelous]
Fallback=ScreenEvaluation

[ScreenEvaluationStage]
Fallback=ScreenEvaluationNoMarvelous
ShowPercentBar=0
Type=stage
EndScreen=ScreenBranchEvaluationSummary
ShowBonusArea=1

[ScreenEvaluationStageLast]
Fallback=ScreenEvaluationStage

[ScreenEvaluationNonstop]
Fallback=ScreenEvaluationMarvelous
ShowPercentBar=0
Type=course
EndScreen=ScreenNameEntry
ShowBonusArea=1
ShowGradeArea=1
ShowGraphArea=1
ShowPointsArea=0
ShowScoreArea=1
ShowSurvivedArea=0
ShowTimeArea=0
DifficultyIconP1Y=999
DifficultyIconP2Y=999
ShowMaxCombo=1

[ScreenEvaluationOni]
Fallback=ScreenEvaluationMarvelous
ShowPercentBar=1
Type=course
EndScreen=ScreenNameEntry
ShowBonusArea=0
ShowGradeArea=0
ShowGraphArea=0
ShowPointsArea=1
ShowScoreArea=0
ShowSurvivedArea=1
ShowTimeArea=1
DifficultyIconP1Y="+rnd.Next(-31, 641)+@"
DifficultyIconP2Y="+rnd.Next(-31, 641)+@"
ShowMaxCombo="+rnd.Next(1, 2)+@"
MaxCombo2NumberP1Y="+rnd.Next(-31, 641)+@"
MaxCombo2NumberP2Y="+rnd.Next(-31, 641)+@"

[ScreenEvaluationSummary]
Fallback=ScreenEvaluationNoMarvelous
ShowPercentBar=0
Type=summary
SmallBanner1X="+rnd.Next(-31, 641)+@"
SmallBanner1Y="+rnd.Next(-31, 641)+@"

[ScreenBranchEvaluation]
Class=ScreenBranch
Choices=1,2,3,4,5,6,7,8
Condition1=IsNetConnected()
Condition2=PlayModeName() == "+'"'+"Nonstop"+'"'+@"
Condition3=PlayModeName() == "+'"'+"Oni"+'"'+@"
Condition4=PlayModeName() == "+'"'+"Endless"+'"'+@"
Condition5=PlayModeName() == "+'"'+"Rave"+'"'+@"
Condition6=PlayModeName() == "+'"'+"Battle"+'"'+@"
Condition7=(IsFinalStage() or IsExtraStage()) and not HasEarnedExtraStage()
Condition8=true
NextScreen1=screen,ScreenNetEvaluation
NextScreen2=screen,ScreenEvaluationNonstop
NextScreen3=screen,ScreenEvaluationOni
NextScreen4=screen,ScreenEvaluationEndless
NextScreen5=screen,ScreenEvaluationRave
NextScreen6=screen,ScreenEvaluationBattle
NextScreen7=screen,ScreenEvaluationStageLast
NextScreen8=screen,ScreenEvaluationStage

[ScreenBranchEvaluationSummary]
Class=ScreenBranch
Choices=1,2
Condition1=(IsFinalStage() and not HasEarnedExtraStage()) and (StageIndex() == 0)
Condition2=true
NextScreen1=screen,ScreenNameEntry
NextScreen2=screen,ScreenEvaluationSummary

[ScreenBranchEnding]
Choices=Credits,MusicScroll
Class=ScreenBranch
ConditionCredits=IsExtraStage2()
ConditionMusicScroll=true
NextScreenCredits=screen,ScreenCredits
NextScreenMusicScroll=screen,ScreenMusicScroll

[ScreenGameOver]
NextScreen=ScreenRanking


// attract screens

[ScreenHowToPlay]
NextScreen=ScreenDemonstration
SecondsToShow=25
UseLifeMeterBar=1
LifeMeterBarOnCommand=x,496;y,18;zoomx,-1
UseCharacter=1
CharacterOnCommand=Zoom,20;X,195;Y,300
UsePad=0
UseNotefield=1
Stepfile=ScreenHowToPlay steps.sm
PlayerX="+rnd.Next(-31, 641)+@"
SongBPM=100
NumPerfects=2
NumMisses=2

[ScreenDemonstration]
SecondsToShow=30
NextScreen=ScreenRanking
DifficultiesToShow=easy
SongsToShow=The legend of MAX,GENOM SCREAMS

[ScreenRanking]
Fallback=ScreenAttract

StepsTypesToHide=dance-couple,dance-solo,pump-halfdouble
ShowCategories=0
CoursesToShow=Courses/nonstop/POP 4.crs,Courses/oni/NAOKI NEO-STANDARD.crs,Courses/oni/DANCEMANIA -ONI-.crs
ShowAllStepsScores=0
ShowAllCourseScores=0
DifficultiesToShow=easy,medium,hard,challenge
NextScreen=ScreenUnlock

SecondsPerPage=6
PageFadeSeconds=2.267
NoScoreName=DDR

RowSpacingX="+rnd.Next(-31, 641)+@"
RowSpacingY="+rnd.Next(-31, 641)+@"
ColSpacingX="+rnd.Next(-31, 641)+@"
ColSpacingY="+rnd.Next(-31, 641)+@"
StepsTypeColor1=#18F7BD
StepsTypeColor2=#FF0000
StepsTypeColor3=#FF0000
StepsTypeColor4=#18F7BD
StepsTypeColor5=#18F7BD

BannerOnCommand=hidden,1
BannerFrameOnCommand=hidden,1
CategoryOnCommand=hidden,1
CourseTitleOnCommand=hidden,1
StepsTypeOnCommand=hidden,1
PageTypeOnCommand=hidden,1

BulletStartX="+rnd.Next(-31, 641)+@"
BulletStartOniX="+rnd.Next(-31, 641)+@"
BulletStartY="+rnd.Next(-31, 641)+@"
Bullet1OnCommand=addx,604;zoom,0.1;sleep,1.450;linear,0.483;addx,-604;zoom,1
Bullet2OnCommand=addx,604;zoom,0.1;sleep,1.150;linear,0.483;addx,-604;zoom,1
Bullet3OnCommand=addx,604;zoom,0.1;sleep,0.850;linear,0.483;addx,-604;zoom,1
Bullet4OnCommand=addx,604;zoom,0.1;sleep,0.550;linear,0.483;addx,-604;zoom,1
Bullet5OnCommand=addx,604;zoom,0.1;sleep,0.250;linear,0.483;addx,-604;zoom,1
Bullet1OffCommand=sleep,1.2;linear,0.3;addx,212;linear,0.3;addx,-274;zoom,0
Bullet2OffCommand=sleep,0.9;linear,0.3;addx,212;linear,0.3;addx,-274;zoom,0
Bullet3OffCommand=sleep,0.6;linear,0.3;addx,212;linear,0.3;addx,-274;zoom,0
Bullet4OffCommand=sleep,0.3;linear,0.3;addx,212;linear,0.3;addx,-274;zoom,0
Bullet5OffCommand=sleep,0.0;linear,0.3;addx,212;linear,0.3;addx,-274;zoom,0
NameStartX="+rnd.Next(-31, 641)+@"
NameStartOniX="+rnd.Next(-31, 641)+@"
NameStartY="+rnd.Next(-31, 641)+@"
Name1OnCommand=horizalign,left;cropleft,1;sleep,1.883;linear,0.05;cropleft,0
Name2OnCommand=horizalign,left;cropleft,1;sleep,1.583;linear,0.05;cropleft,0
Name3OnCommand=horizalign,left;cropleft,1;sleep,1.283;linear,0.05;cropleft,0
Name4OnCommand=horizalign,left;cropleft,1;sleep,0.983;linear,0.05;cropleft,0
Name5OnCommand=horizalign,left;cropleft,1;sleep,0.683;linear,0.05;cropleft,0
Name1OffCommand=sleep,1.2;linear,0.05;addx,-40;cropleft,1
Name2OffCommand=sleep,0.9;linear,0.05;addx,-40;cropleft,1
Name3OffCommand=sleep,0.6;linear,0.05;addx,-40;cropleft,1
Name4OffCommand=sleep,0.3;linear,0.05;addx,-40;cropleft,1
Name5OffCommand=sleep,0.0;linear,0.05;addx,-40;cropleft,1
ScoreStartX="+rnd.Next(-31, 641)+@"
ScoreStartY="+rnd.Next(-31, 641)+@" 
Score1OnCommand=horizalign,right;cropleft,1;zoomy,0.5;sleep,1.6;linear,0.2;cropleft,0;zoomy,1
Score2OnCommand=horizalign,right;cropleft,1;zoomy,0.5;sleep,1.3;linear,0.2;cropleft,0;zoomy,1
Score3OnCommand=horizalign,right;cropleft,1;zoomy,0.5;sleep,1.0;linear,0.2;cropleft,0;zoomy,1
Score4OnCommand=horizalign,right;cropleft,1;zoomy,0.5;sleep,0.7;linear,0.2;cropleft,0;zoomy,1
Score5OnCommand=horizalign,right;cropleft,1;zoomy,0.5;sleep,0.4;linear,0.2;cropleft,0;zoomy,1
Score1OffCommand=sleep,1.2;linear,0.083;addx,-82;linear,0.133;addx,-130;cropleft,1
Score2OffCommand=sleep,0.9;linear,0.083;addx,-82;linear,0.133;addx,-130;cropleft,1
Score3OffCommand=sleep,0.6;linear,0.083;addx,-82;linear,0.133;addx,-130;cropleft,1
Score4OffCommand=sleep,0.3;linear,0.083;addx,-82;linear,0.133;addx,-130;cropleft,1
Score5OffCommand=linear,0.083;addx,-82;linear,0.133;addx,-130;cropleft,1
PointsStartX="+rnd.Next(-31, 641)+@"
PointsStartY="+rnd.Next(-31, 641)+@"
Points1OnCommand=cropleft,1;zoom,0.9;sleep,1.683;linear,0.1;zoom,1;cropleft,0
Points2OnCommand=cropleft,1;zoom,0.9;sleep,1.383;linear,0.1;zoom,1;cropleft,0
Points3OnCommand=cropleft,1;zoom,0.9;sleep,1.083;linear,0.1;zoom,1;cropleft,0
Points4OnCommand=cropleft,1;zoom,0.9;sleep,0.783;linear,0.1;zoom,1;cropleft,0
Points5OnCommand=cropleft,1;zoom,0.9;sleep,0.483;linear,0.1;zoom,1;cropleft,0
Points1OffCommand=sleep,1.2;linear,0.083;addx,-90;linear,0.066;cropleft,1;addx,-64
Points2OffCommand=sleep,0.9;linear,0.083;addx,-90;linear,0.066;cropleft,1;addx,-64
Points3OffCommand=sleep,0.6;linear,0.083;addx,-90;linear,0.066;cropleft,1;addx,-64
Points4OffCommand=sleep,0.3;linear,0.083;addx,-90;linear,0.066;cropleft,1;addx,-64
Points5OffCommand=sleep,0.0;linear,0.083;addx,-90;linear,0.066;cropleft,1;addx,-64
TimeStartX="+rnd.Next(-31, 641)+@"
TimeStartY="+rnd.Next(-31, 641)+@"
Time1OnCommand=horizalign,left;cropleft,1;zoom,0.6;sleep,1.563;linear,0.1;cropleft,0;zoom,0.75;linear,0.183;zoom,1
Time2OnCommand=horizalign,left;cropleft,1;zoom,0.6;sleep,1.263;linear,0.1;cropleft,0;zoom,0.75;linear,0.183;zoom,1
Time3OnCommand=horizalign,left;cropleft,1;zoom,0.6;sleep,0.963;linear,0.1;cropleft,0;zoom,0.75;linear,0.183;zoom,1
Time4OnCommand=horizalign,left;cropleft,1;zoom,0.6;sleep,0.663;linear,0.1;cropleft,0;zoom,0.75;linear,0.183;zoom,1
Time5OnCommand=horizalign,left;cropleft,1;zoom,0.6;sleep,0.363;linear,0.1;cropleft,0;zoom,0.75;linear,0.183;zoom,1
Time1OffCommand=sleep,1.2;linear,0.166;addx,-186;linear,0.116;addx,-96;cropleft,1
Time2OffCommand=sleep,0.9;linear,0.166;addx,-186;linear,0.116;addx,-96;cropleft,1
Time3OffCommand=sleep,0.6;linear,0.166;addx,-186;linear,0.116;addx,-96;cropleft,1
Time4OffCommand=sleep,0.3;linear,0.166;addx,-186;linear,0.116;addx,-96;cropleft,1
Time5OffCommand=sleep,0.0;linear,0.166;addx,-186;linear,0.116;addx,-96;cropleft,1

[ScreenUnlock]
Class=ScreenAttract
Fallback=ScreenAttract

[ScreenCredits]
Class=ScreenAttract
Fallback=ScreenAttract

[ScreenMusicScroll]
ScrollDelay="+rnd.Next(0, 2)+@"
ScrollSpeed="+rnd.Next(2, 11)+@"
TextZoom=1.0
NextScreen=ScreenRanking");
			System.IO.File.WriteAllText(@"C:/stepmania-modified/game/Data/StepMania.ini", @"[Debug]
ForceLogFlush=0
LogCheckpoints=0
LogFPS=0
LogSkips=0
LogToDisk=0
ShowLoadingWindow=1
ShowLogOutput=0
Timestamping=0

[Editor]
ShowBGChangesPlay=1

[Options]
AdditionalFolders=
AdditionalSongFolders=
AllowExtraStage=1
AllowUnacceleratedRenderer=0
AnisotropicFiltering=0
ArcadeEventMode=0
ArcadeOptionsNavigation=0
AttractSoundFrequency=1
AutoMapJoysticks=1
AutoPlay=0
AutoRestart=0
AutogenGroupCourses=1
AutogenSteps=1
BGBrightness=1.000000
BackgroundMode=3
BannerCache=1
BlinkGameplayButtonLightsOnNote=0
BoostAppPriority=-1
BreakComboToGetItem=0
Caution="+rnd.Next(1, 2)+@"
CelShadeModels=1
CenterImageScaleX=1.000000
CenterImageScaleY=1.000000
CenterImageTranslateX=0
CenterImageTranslateY=0
CoinMode="+rnd.Next(1, 3)+@"
CoinsPerCredit="+rnd.Next(2, 9)+@"
ComboContinuesBetweenSongs=0
ConstantUpdateDeltaSeconds=0.000000
CourseSortOrder=0
CoursesToShowRanking=Courses/nonstop/POP 4.crs,Courses/oni/NAOKI NEO-STANDARD.crs,Courses/oni/DANCEMANIA -ONI-.crs
DancePointsForOni=1
DebounceTime=0.010000
DefaultLocalProfileIDP1=
DefaultLocalProfileIDP2=
DelayedCreditsReconcile=0
DelayedEscape=1
DelayedModelDelete=0
DelayedScreenLoad="+rnd.Next(1, 2)+@"
DelayedTextureDelete=1
DisableScreenSaver=1
DisplayColorDepth=16
DisplayHeight=480
DisplayWidth=640
Disqualification=0
EasterEggs=0
EnableBGAnim=1
EndlessBreakEnabled=1
EndlessBreakLength=5
EndlessStagesUntilBreak=5
EventMode="+rnd.Next(1, 2)+@"
FastLoad="+rnd.Next(1, 2)+@"
FirstRun="+rnd.Next(1, 2)+@"
ForceMipMaps=0
GetRankingName=2
GlobalOffsetSeconds=0.000000
GradePercentTier01=1.000000
GradePercentTier02=1.000000
GradePercentTier03=0.930000
GradePercentTier04=0.800000
GradePercentTier05=0.650000
GradePercentTier06=0.450000
GradePercentTier07=-99999.000000
GradePercentTier08=0.000000
GradePercentTier09=0.000000
GradePercentTier10=0.000000
GradePercentTier11=0.000000
GradePercentTier12=0.000000
GradePercentTier13=0.000000
GradePercentTier14=0.000000
GradePercentTier15=0.000000
GradePercentTier16=0.000000
GradePercentTier17=0.000000
GradePercentTier18=0.000000
GradePercentTier19=0.000000
GradePercentTier20=0.000000
GradeTier02IsAllPerfects=1
GradeWeightBoo="+rnd.Next(-5, 3)+@"
GradeWeightGood="+rnd.Next(-5, 3)+@"
GradeWeightGreat="+rnd.Next(-5, 3)+@"
GradeWeightHitMine="+rnd.Next(-5, 3)+@"
GradeWeightMarvelous="+rnd.Next(-5, 3)+@"
GradeWeightMiss="+rnd.Next(-5, 3)+@"
GradeWeightNG="+rnd.Next(-5, 3)+@"
GradeWeightOK="+rnd.Next(-5, 3)+@"
GradeWeightPerfect=2
HiddenSongs="+rnd.Next(1, 2)+@"
HideDefaultNoteSkin=0
HowToPlay="+rnd.Next(1, 2)+@"
IgnoredMessageWindows=
Interlaced=0
JudgeWindowAdd=0.000000
JudgeWindowScale=1.000000
JudgeWindowSecondsAttack=0.135000
JudgeWindowSecondsBoo=0.158333
JudgeWindowSecondsGood=0.120000
JudgeWindowSecondsGreat=0.083000
JudgeWindowSecondsMarvelous=0.016666
JudgeWindowSecondsMine=0.083000
JudgeWindowSecondsOK=0.250000
JudgeWindowSecondsPerfect=0.033333
Language=
LastSeenInputDevices=Keyboard
LastSeenMemory=2047
LastSeenVideoDriver=Intel(R) HD Graphics 4000
LifeDeltaPercentChangeBoo=-0.040000
LifeDeltaPercentChangeGood=0.000000
LifeDeltaPercentChangeGreat=0.004000
LifeDeltaPercentChangeHitMine=-0.160000
LifeDeltaPercentChangeMarvelous=0.008000
LifeDeltaPercentChangeMiss=-0.080000
LifeDeltaPercentChangeNG=-0.080000
LifeDeltaPercentChangeOK=0.008000
LifeDeltaPercentChangePerfect=0.008000
LifeDifficultyScale=1.000000
LightsStepsDifficulty=medium
LockCourseDifficulties=1
LongVerSeconds=150.000000
MachineName="+rnd.Next(1, 10000000)+@"
MarathonVerSeconds=300.000000
MarvelousTiming=1
MaxHighScoresPerListForMachine=10
MaxHighScoresPerListForPlayer=3
MaxRegenComboAfterFail=10
MaxRegenComboAfterMiss=10
MaxTextureResolution=1024
MemoryCardOsMountPointP1=
MemoryCardOsMountPointP2=
MemoryCardProfileSubdir=StepMania
MemoryCardUsbBusP1=-1
MemoryCardUsbBusP2=-1
MemoryCardUsbLevelP1=-1
MemoryCardUsbLevelP2=-1
MemoryCardUsbPortP1=-1
MemoryCardUsbPortP2=-1
MemoryCards=0
MenuTimer="+rnd.Next(1, 2)+@"
MercifulDrain="+rnd.Next(1, 2)+@"
MercifulSuperMeter="+rnd.Next(1, 2)+@"
MinPercentageForMachineCourseHighScore=0.001000
MinPercentageForMachineSongHighScore=0.500000
Minimum1FullSongInCourses=0
MoveRandomToEnd=0
MovieColorDepth=16
MusicWheelSwitchSpeed=10
MusicWheelUsesSections=1
NumArcadeStages=3
NumBackgrounds=20
NumGradeTiersUsed=7
PAL="+rnd.Next(1, 2)+@"
PadStickSeconds=0.000000
PalettedBannerCache=0
PercentScoreWeightBoo="+rnd.Next(-5, 3)+@"
PercentScoreWeightGood="+rnd.Next(-5, 3)+@"
PercentScoreWeightGreat="+rnd.Next(-5, 3)+@"
PercentScoreWeightHitMine="+rnd.Next(-5, 3)+@"
PercentScoreWeightMarvelous"+rnd.Next(-5, 3)+@"
PercentScoreWeightMiss="+rnd.Next(-5, 3)+@"
PercentScoreWeightNG="+rnd.Next(-5, 3)+@"
PercentScoreWeightOK="+rnd.Next(-5, 3)+@"
PercentScoreWeightPerfect="+rnd.Next(-5, 3)+@"
PercentageScoring="+rnd.Next(-5, 3)+@"
PickExtraStage="+rnd.Next(-5, 3)+@"
Premium="+rnd.Next(-5, 3)+@"
ProductID=1
ProgressiveLifebar=0
ProgressiveNonstopLifebar=1
ProgressiveStageLifebar=1
RefreshRate=0
RegenComboAfterFail=10
RegenComboAfterMiss=5
ScoringType=0
ScreenTestMode=0
ShowBanners="+rnd.Next(-5, 3)+@"
ShowBeginnerHelper="+rnd.Next(-5, 3)+@"
ShowDancingCharacters="+rnd.Next(-5, 3)+@"
ShowDanger="+rnd.Next(-5, 3)+@"
ShowLyrics="+rnd.Next(-5, 3)+@"
ShowNative=0
ShowSelectGroup=1
ShowSongOptions=0
ShowStats=0
SignProfileData=0
SmoothLines=0
SoloSingle=0
SoundDevice=
SoundDrivers=
SoundResampleQuality=1
SoundWriteAhead=0
SubSortByNumSteps=0
SuperMeterPercentChangeBoo=0.000000
SuperMeterPercentChangeGood=0.000000
SuperMeterPercentChangeGreat=0.020000
SuperMeterPercentChangeHitMine=-0.400000
SuperMeterPercentChangeMarvelous=0.050000
SuperMeterPercentChangeMiss=-0.200000
SuperMeterPercentChangeNG=-0.200000
SuperMeterPercentChangeOK=0.040000
SuperMeterPercentChangePerfect=0.040000
TextureColorDepth=16
TexturePreload=0
ThreadedInput=1
ThreadedMovieDecode=1
TrilinearFiltering=0
TugMeterPercentChangeBoo=-0.010000
TugMeterPercentChangeGood=0.000000
TugMeterPercentChangeGreat=0.004000
TugMeterPercentChangeHitMine=-0.040000
TugMeterPercentChangeMarvelous=0.010000
TugMeterPercentChangeMiss=-0.020000
TugMeterPercentChangeNG=-0.020000
TugMeterPercentChangeOK=0.008000
TugMeterPercentChangePerfect=0.008000
TwoPlayerRecovery="+rnd.Next(-5, 3)+@"
UseDedicatedMenuButtons=0
UseUnlockSystem="+rnd.Next(-5, 3)+@"
VideoRenderers=d3d,opengl
Vsync=1
Windowed=1
");
			Console.WriteLine("Rewriting... (C:/stepmania-modified/game/Data/ai.ini)");
			System.IO.File.WriteAllText(@"C:\stepmania-modified\game\Data\ai.ini", @"[Skill0]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill1]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill2]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill3]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill4]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill5]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31)+@"

[Skill6]
MissWeight="+rnd.Next(1, 31)+@"
BooWeight="+rnd.Next(1, 31)+@"
GoodWeight="+rnd.Next(1, 31)+@"
GreatWeight="+rnd.Next(1, 31)+@"
PerfectWeight="+rnd.Next(1, 31)+@"
MarvelousWeight="+rnd.Next(1, 31));
			Console.WriteLine("Done! Now press F2 in Stepmania.");
		}
	}
}