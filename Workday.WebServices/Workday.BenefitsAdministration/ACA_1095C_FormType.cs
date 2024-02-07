using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "ACA_1095-C_FormType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ACA_1095C_FormType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private External_1095C_RecipientObjectType external_1095C_Recipient_ReferenceField;

		private string generation_SourceField;

		private bool is_TransmittedField;

		private bool is_TransmittedFieldSpecified;

		private ACA_1095C_Form_DataType aCA_1095C_Form_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement("External_1095-C_Recipient_Reference", Order = 1)]
		public External_1095C_RecipientObjectType External_1095C_Recipient_Reference
		{
			get
			{
				return this.external_1095C_Recipient_ReferenceField;
			}
			set
			{
				this.external_1095C_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("External_1095C_Recipient_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Generation_Source
		{
			get
			{
				return this.generation_SourceField;
			}
			set
			{
				this.generation_SourceField = value;
				this.RaisePropertyChanged("Generation_Source");
			}
		}

		[XmlElement(Order = 3)]
		public bool Is_Transmitted
		{
			get
			{
				return this.is_TransmittedField;
			}
			set
			{
				this.is_TransmittedField = value;
				this.RaisePropertyChanged("Is_Transmitted");
			}
		}

		[XmlIgnore]
		public bool Is_TransmittedSpecified
		{
			get
			{
				return this.is_TransmittedFieldSpecified;
			}
			set
			{
				this.is_TransmittedFieldSpecified = value;
				this.RaisePropertyChanged("Is_TransmittedSpecified");
			}
		}

		[XmlElement("ACA_1095-C_Form_Data", Order = 4)]
		public ACA_1095C_Form_DataType ACA_1095C_Form_Data
		{
			get
			{
				return this.aCA_1095C_Form_DataField;
			}
			set
			{
				this.aCA_1095C_Form_DataField = value;
				this.RaisePropertyChanged("ACA_1095C_Form_Data");
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
