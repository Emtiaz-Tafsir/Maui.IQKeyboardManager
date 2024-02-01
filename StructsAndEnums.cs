using System;
using ObjCRuntime;

namespace Maui
{
    [Native]
    public enum IQAutoToolbarManageBehaviour : long
    {
	Subviews,
	Tag,
	Position
    }

    [Native]
    public enum IQPreviousNextDisplayMode : long
    {
	Default,
	AlwaysHide,
	AlwaysShow
    }

    [Native]
    public enum IQLayoutGuidePosition : long
    {
	None,
	Top,
	Bottom
    }
}