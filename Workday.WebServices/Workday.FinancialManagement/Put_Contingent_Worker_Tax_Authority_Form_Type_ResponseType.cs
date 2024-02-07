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
	public class Put_Contingent_Worker_Tax_Authority_Form_Type_ResponseType : INotifyPropertyChanged
	{
		private Contingent_WorkerObjectType contingent_Worker_Tax_Authority_Form_Type_ReferenceField;

		private Tax_Authority_Form_TypeObjectType tax_Authority_Form_Type_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contingent_WorkerObjectType Contingent_Worker_Tax_Authority_Form_Type_Reference
		{
			get
			{
				return this.contingent_Worker_Tax_Authority_Form_Type_ReferenceField;
			}
			set
			{
				this.contingent_Worker_Tax_Authority_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contingent_Worker_Tax_Authority_Form_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_Authority_Form_TypeObjectType Tax_Authority_Form_Type_Reference
		{
			get
			{
				return this.tax_Authority_Form_Type_ReferenceField;
			}
			set
			{
				this.tax_Authority_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Form_Type_Reference");
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
