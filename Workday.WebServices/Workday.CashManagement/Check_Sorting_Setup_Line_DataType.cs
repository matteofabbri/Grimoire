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
	public class Check_Sorting_Setup_Line_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] check_Sorting_Setup_Line_ReferenceField;

		private string check_Sorting_OrderField;

		private Unique_IdentifierObjectType check_Sorting_Value_ReferenceField;

		private string split_BatchField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Check_Sorting_Setup_Line_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Check_Sorting_Setup_Line_Reference
		{
			get
			{
				return this.check_Sorting_Setup_Line_ReferenceField;
			}
			set
			{
				this.check_Sorting_Setup_Line_ReferenceField = value;
				this.RaisePropertyChanged("Check_Sorting_Setup_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Check_Sorting_Order
		{
			get
			{
				return this.check_Sorting_OrderField;
			}
			set
			{
				this.check_Sorting_OrderField = value;
				this.RaisePropertyChanged("Check_Sorting_Order");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Check_Sorting_Value_Reference
		{
			get
			{
				return this.check_Sorting_Value_ReferenceField;
			}
			set
			{
				this.check_Sorting_Value_ReferenceField = value;
				this.RaisePropertyChanged("Check_Sorting_Value_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Split_Batch
		{
			get
			{
				return this.split_BatchField;
			}
			set
			{
				this.split_BatchField = value;
				this.RaisePropertyChanged("Split_Batch");
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
