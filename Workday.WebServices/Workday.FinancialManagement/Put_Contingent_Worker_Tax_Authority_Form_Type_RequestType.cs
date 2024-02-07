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
	public class Put_Contingent_Worker_Tax_Authority_Form_Type_RequestType : INotifyPropertyChanged
	{
		private Contingent_WorkerObjectType contingent_Worker_ReferenceField;

		private Contingent_Worker_Tax_Authority_Form_Type_DataType contingent_Worker_Tax_Authority_Form_Type_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contingent_WorkerObjectType Contingent_Worker_Reference
		{
			get
			{
				return this.contingent_Worker_ReferenceField;
			}
			set
			{
				this.contingent_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Contingent_Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Contingent_Worker_Tax_Authority_Form_Type_DataType Contingent_Worker_Tax_Authority_Form_Type_Data
		{
			get
			{
				return this.contingent_Worker_Tax_Authority_Form_Type_DataField;
			}
			set
			{
				this.contingent_Worker_Tax_Authority_Form_Type_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Tax_Authority_Form_Type_Data");
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
