using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "External_Disability_Self-Identification_RecordType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Disability_SelfIdentification_RecordType : INotifyPropertyChanged
	{
		private External_Disability_SelfIdentification_RecordObjectType external_Disability_Self_Identification_Record_ReferenceField;

		private External_Disability_SelfIdentification_Record_DataType external_Disability_Self_Identification_Record_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Disability_SelfIdentification_RecordObjectType External_Disability_Self_Identification_Record_Reference
		{
			get
			{
				return this.external_Disability_Self_Identification_Record_ReferenceField;
			}
			set
			{
				this.external_Disability_Self_Identification_Record_ReferenceField = value;
				this.RaisePropertyChanged("External_Disability_Self_Identification_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public External_Disability_SelfIdentification_Record_DataType External_Disability_Self_Identification_Record_Data
		{
			get
			{
				return this.external_Disability_Self_Identification_Record_DataField;
			}
			set
			{
				this.external_Disability_Self_Identification_Record_DataField = value;
				this.RaisePropertyChanged("External_Disability_Self_Identification_Record_Data");
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
