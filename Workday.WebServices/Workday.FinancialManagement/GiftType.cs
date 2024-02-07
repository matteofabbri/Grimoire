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
	public class GiftType : INotifyPropertyChanged
	{
		private GiftObjectType gift_ReferenceField;

		private Gift_DataType[] gift_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GiftObjectType Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement("Gift_Data", Order = 1)]
		public Gift_DataType[] Gift_Data
		{
			get
			{
				return this.gift_DataField;
			}
			set
			{
				this.gift_DataField = value;
				this.RaisePropertyChanged("Gift_Data");
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
