using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Educational_Institution_Ethnicity_Information_DataType : INotifyPropertyChanged
	{
		private Educational_Institution_Ethnicity_InformationObjectType educational_Institution_Ethnicity_Information_ReferenceField;

		private decimal countField;

		private EthnicityObjectType ethnicity_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_Institution_Ethnicity_InformationObjectType Educational_Institution_Ethnicity_Information_Reference
		{
			get
			{
				return this.educational_Institution_Ethnicity_Information_ReferenceField;
			}
			set
			{
				this.educational_Institution_Ethnicity_Information_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Ethnicity_Information_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		[XmlElement(Order = 2)]
		public EthnicityObjectType Ethnicity_Reference
		{
			get
			{
				return this.ethnicity_ReferenceField;
			}
			set
			{
				this.ethnicity_ReferenceField = value;
				this.RaisePropertyChanged("Ethnicity_Reference");
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
