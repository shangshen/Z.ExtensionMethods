
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_214

	''' <summary>
	'''     Returns the largest integer less than or equal to the specified double-precision floating-point number.
	''' </summary>
	''' <param name="d">A double-precision floating-point number.</param>
	''' <returns>The largest integer less than or equal to . If  is equal to , , or , that value is returned.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Floor(d As [Double]) As [Double]
		Return Math.Floor(d)
	End Function
End Module


