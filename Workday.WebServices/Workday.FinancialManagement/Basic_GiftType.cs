using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Basic_GiftType : INotifyPropertyChanged
	{
		private GiftObjectType basic_Gift_ReferenceField;

		private Basic_Gift_DataType basic_Gift_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GiftObjectType Basic_Gift_Reference
		{
			get
			{
				return this.basic_Gift_ReferenceField;
			}
			set
			{
				this.basic_Gift_ReferenceField = value;
				this.RaisePropertyChanged("Basic_Gift_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Basic_Gift_DataType Basic_Gift_Data
		{
			get
			{
				return this.basic_Gift_DataField;
			}
			set
			{
				this.basic_Gift_DataField = value;
				this.RaisePropertyChanged("Basic_Gift_Data");
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
