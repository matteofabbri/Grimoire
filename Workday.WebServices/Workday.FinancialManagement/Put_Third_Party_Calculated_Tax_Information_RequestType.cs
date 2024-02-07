using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Third_Party_Calculated_Tax_Information_RequestType : INotifyPropertyChanged
	{
		private Taxable_DocumentObjectType taxable_Document_ReferenceField;

		private Taxable_Document_DataType[] taxable_Document_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Taxable_DocumentObjectType Taxable_Document_Reference
		{
			get
			{
				return this.taxable_Document_ReferenceField;
			}
			set
			{
				this.taxable_Document_ReferenceField = value;
				this.RaisePropertyChanged("Taxable_Document_Reference");
			}
		}

		[XmlElement("Taxable_Document_Data", Order = 1)]
		public Taxable_Document_DataType[] Taxable_Document_Data
		{
			get
			{
				return this.taxable_Document_DataField;
			}
			set
			{
				this.taxable_Document_DataField = value;
				this.RaisePropertyChanged("Taxable_Document_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
