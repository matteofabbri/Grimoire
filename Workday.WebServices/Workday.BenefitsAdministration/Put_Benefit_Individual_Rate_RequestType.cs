using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Benefit_Individual_Rate_RequestType : INotifyPropertyChanged
	{
		private Benefit_Individual_RateObjectType benefit_Individual_Rate_ReferenceField;

		private Benefit_Individual_Rate_DataType benefit_Individual_Rate_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_Individual_RateObjectType Benefit_Individual_Rate_Reference
		{
			get
			{
				return this.benefit_Individual_Rate_ReferenceField;
			}
			set
			{
				this.benefit_Individual_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Individual_Rate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Benefit_Individual_Rate_DataType Benefit_Individual_Rate_Data
		{
			get
			{
				return this.benefit_Individual_Rate_DataField;
			}
			set
			{
				this.benefit_Individual_Rate_DataField = value;
				this.RaisePropertyChanged("Benefit_Individual_Rate_Data");
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
