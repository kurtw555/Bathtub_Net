Imports Microsoft.Office.Interop.Excel
<System.Runtime.InteropServices.Guid("000208D9-0000-0000-C000-000000000046")>
Public Interface IGlobal
	Inherits Microsoft.Office.Interop.Excel._Global
End Interface


Module UpgradeSupport
	'UPGRADE_NOTE: (7014) The property 'Excel_Global_definst' could be being created from different 'UpgradeSupport' in a multiproject solution More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7014
	Private _Excel_Global_definst As IGlobal = Nothing
	Public ReadOnly Property Excel_Global_definst() As IGlobal
		Get

			If _Excel_Global_definst Is Nothing Then
				_Excel_Global_definst = New Microsoft.Office.Interop.Excel.Application()
			End If
			Return _Excel_Global_definst
		End Get
	End Property
End Module