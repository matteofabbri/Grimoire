using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Tax_CodeType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payee_Tax_Code_ReferenceField;

		private Payee_Tax_Code_DataType[] payee_Tax_Code_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payee_Tax_Code_Reference
		{
			get
			{
				return this.payee_Tax_Code_ReferenceField;
			}
			set
			{
				this.payee_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Tax_Code_Reference");
			}
		}

		[XmlElement("Payee_Tax_Code_Data", Order = 1)]
		public Payee_Tax_Code_DataType[] Payee_Tax_Code_Data
		{
			get
			{
				return this.payee_Tax_Code_DataField;
			}
			set
			{
				this.payee_Tax_Code_DataField = value;
				this.RaisePropertyChanged("Payee_Tax_Code_Data");
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
