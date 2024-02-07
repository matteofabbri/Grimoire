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
	public class Financial_InstitutionType : INotifyPropertyChanged
	{
		private Financial_InstitutionObjectType financial_Institution_ReferenceField;

		private Financial_Institution_WWS_DataType[] financial_Institution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financial_InstitutionObjectType Financial_Institution_Reference
		{
			get
			{
				return this.financial_Institution_ReferenceField;
			}
			set
			{
				this.financial_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference");
			}
		}

		[XmlElement("Financial_Institution_Data", Order = 1)]
		public Financial_Institution_WWS_DataType[] Financial_Institution_Data
		{
			get
			{
				return this.financial_Institution_DataField;
			}
			set
			{
				this.financial_Institution_DataField = value;
				this.RaisePropertyChanged("Financial_Institution_Data");
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
