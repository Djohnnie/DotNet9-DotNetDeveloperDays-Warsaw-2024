using System.Diagnostics;

var curtain = Pattern.Solid;

Debug.Assert(curtain is Pattern.Dotted or Pattern.Dashed);


enum Pattern
{
    None,
    Solid,
    Dotted,
    Dashed,
    DashDot,
    DashDotDot
}