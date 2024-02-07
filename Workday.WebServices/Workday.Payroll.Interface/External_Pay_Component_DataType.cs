using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Pay_Component_DataType : INotifyPropertyChanged
	{
		private string codeField;

		private string nameField;

		private bool position_BasedField;

		private bool position_BasedFieldSpecified;

		private FrequencyObjectType override_Frequency_ReferenceField;

		private decimal frequency_FactorField;

		private bool frequency_FactorFieldSpecified;

		private Group_InterfaceObjectType[] tag_ReferenceField;

		private Pay_GroupObjectType[] pay_Group_ReferenceField;

		private Group_InterfaceObjectType[] inbound_Reporting_Tag_ReferenceField;

		private bool inbound_OnlyField;

		private bool inbound_OnlyFieldSpecified;

		private string external_Payroll_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
				this.RaisePropertyChanged("Code");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Position_Based
		{
			get
			{
				return this.position_BasedField;
			}
			set
			{
				this.position_BasedField = value;
				this.RaisePropertyChanged("Position_Based");
			}
		}

		[XmlIgnore]
		public bool Position_BasedSpecified
		{
			get
			{
				return this.position_BasedFieldSpecified;
			}
			set
			{
				this.position_BasedFieldSpecified = value;
				this.RaisePropertyChanged("Position_BasedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public FrequencyObjectType Override_Frequency_Reference
		{
			get
			{
				return this.override_Frequency_ReferenceField;
			}
			set
			{
				this.override_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Override_Frequency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Frequency_Factor
		{
			get
			{
				return this.frequency_FactorField;
			}
			set
			{
				this.frequency_FactorField = value;
				this.RaisePropertyChanged("Frequency_Factor");
			}
		}

		[XmlIgnore]
		public bool Frequency_FactorSpecified
		{
			get
			{
				return this.frequency_FactorFieldSpecified;
			}
			set
			{
				this.frequency_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Frequency_FactorSpecified");
			}
		}

		[XmlElement("Tag_Reference", Order = 5)]
		public Group_InterfaceObjectType[] Tag_Reference
		{
			get
			{
				return this.tag_ReferenceField;
			}
			set
			{
				this.tag_ReferenceField = value;
				this.RaisePropertyChanged("Tag_Reference");
			}
		}

		[XmlElement("Pay_Group_Reference", Order = 6)]
		public Pay_GroupObjectType[] Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement("Inbound_Reporting_Tag_Reference", Order = 7)]
		public Group_InterfaceObjectType[] Inbound_Reporting_Tag_Reference
		{
			get
			{
				return this.inbound_Reporting_Tag_ReferenceField;
			}
			set
			{
				this.inbound_Reporting_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Inbound_Reporting_Tag_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Inbound_Only
		{
			get
			{
				return this.inbound_OnlyField;
			}
			set
			{
				this.inbound_OnlyField = value;
				this.RaisePropertyChanged("Inbound_Only");
			}
		}

		[XmlIgnore]
		public bool Inbound_OnlySpecified
		{
			get
			{
				return this.inbound_OnlyFieldSpecified;
			}
			set
			{
				this.inbound_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Inbound_OnlySpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string External_Payroll_Code
		{
			get
			{
				return this.external_Payroll_CodeField;
			}
			set
			{
				this.external_Payroll_CodeField = value;
				this.RaisePropertyChanged("External_Payroll_Code");
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
