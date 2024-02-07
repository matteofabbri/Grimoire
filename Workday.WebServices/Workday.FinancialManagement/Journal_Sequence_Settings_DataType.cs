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
	public class Journal_Sequence_Settings_DataType : INotifyPropertyChanged
	{
		private bool enable_Journal_SequencingField;

		private bool enable_Journal_SequencingFieldSpecified;

		private Sequence_Generator_Rule_ConfigurationObjectType sequence_Generator_Rule_Configuration_ReferenceField;

		private Unique_IdentifierObjectType sequencing_Start_Period_ReferenceField;

		private bool create_Sequence_ID_Generators_with_New_Ledger_YearsField;

		private bool create_Sequence_ID_Generators_with_New_Ledger_YearsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Enable_Journal_Sequencing
		{
			get
			{
				return this.enable_Journal_SequencingField;
			}
			set
			{
				this.enable_Journal_SequencingField = value;
				this.RaisePropertyChanged("Enable_Journal_Sequencing");
			}
		}

		[XmlIgnore]
		public bool Enable_Journal_SequencingSpecified
		{
			get
			{
				return this.enable_Journal_SequencingFieldSpecified;
			}
			set
			{
				this.enable_Journal_SequencingFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Journal_SequencingSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Sequence_Generator_Rule_ConfigurationObjectType Sequence_Generator_Rule_Configuration_Reference
		{
			get
			{
				return this.sequence_Generator_Rule_Configuration_ReferenceField;
			}
			set
			{
				this.sequence_Generator_Rule_Configuration_ReferenceField = value;
				this.RaisePropertyChanged("Sequence_Generator_Rule_Configuration_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Sequencing_Start_Period_Reference
		{
			get
			{
				return this.sequencing_Start_Period_ReferenceField;
			}
			set
			{
				this.sequencing_Start_Period_ReferenceField = value;
				this.RaisePropertyChanged("Sequencing_Start_Period_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Create_Sequence_ID_Generators_with_New_Ledger_Years
		{
			get
			{
				return this.create_Sequence_ID_Generators_with_New_Ledger_YearsField;
			}
			set
			{
				this.create_Sequence_ID_Generators_with_New_Ledger_YearsField = value;
				this.RaisePropertyChanged("Create_Sequence_ID_Generators_with_New_Ledger_Years");
			}
		}

		[XmlIgnore]
		public bool Create_Sequence_ID_Generators_with_New_Ledger_YearsSpecified
		{
			get
			{
				return this.create_Sequence_ID_Generators_with_New_Ledger_YearsFieldSpecified;
			}
			set
			{
				this.create_Sequence_ID_Generators_with_New_Ledger_YearsFieldSpecified = value;
				this.RaisePropertyChanged("Create_Sequence_ID_Generators_with_New_Ledger_YearsSpecified");
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
