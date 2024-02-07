using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_Tax_Authority_Form_Information_DataType : INotifyPropertyChanged
	{
		private Tax_Authority_Form_TypeObjectType tax_Authority_Form_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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
