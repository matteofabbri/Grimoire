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
	public class Contingent_Worker_Tax_Authority_Form_Type_DataType : INotifyPropertyChanged
	{
		private string contingent_Worker_IDField;

		private Tax_Authority_Form_TypeObjectType contingent_Worker_Tax_Authority_Form_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Contingent_Worker_ID
		{
			get
			{
				return this.contingent_Worker_IDField;
			}
			set
			{
				this.contingent_Worker_IDField = value;
				this.RaisePropertyChanged("Contingent_Worker_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_Authority_Form_TypeObjectType Contingent_Worker_Tax_Authority_Form_Type_Reference
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
