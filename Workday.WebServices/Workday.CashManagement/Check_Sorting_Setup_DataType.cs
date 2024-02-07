using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Check_Sorting_Setup_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType check_Sorting_Setup_ReferenceField;

		private Check_Sorting_Setup_Line_DataType[] check_Sorting_Setup_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Check_Sorting_Setup_Reference
		{
			get
			{
				return this.check_Sorting_Setup_ReferenceField;
			}
			set
			{
				this.check_Sorting_Setup_ReferenceField = value;
				this.RaisePropertyChanged("Check_Sorting_Setup_Reference");
			}
		}

		[XmlElement("Check_Sorting_Setup_Line_Data", Order = 1)]
		public Check_Sorting_Setup_Line_DataType[] Check_Sorting_Setup_Line_Data
		{
			get
			{
				return this.check_Sorting_Setup_Line_DataField;
			}
			set
			{
				this.check_Sorting_Setup_Line_DataField = value;
				this.RaisePropertyChanged("Check_Sorting_Setup_Line_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
