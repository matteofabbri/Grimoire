using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Named_Professorship_Snapshot_DataType : INotifyPropertyChanged
	{
		private GiftObjectType gift_ReferenceField;

		private string professorship_NameField;

		private string named_Professorship_TitleField;

		private Academic_UnitObjectType academic_Unit_for_Named_Professorship_ReferenceField;

		private decimal term_LimitsField;

		private bool term_LimitsFieldSpecified;

		private string appointment_RestrictionsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GiftObjectType Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Professorship_Name
		{
			get
			{
				return this.professorship_NameField;
			}
			set
			{
				this.professorship_NameField = value;
				this.RaisePropertyChanged("Professorship_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Named_Professorship_Title
		{
			get
			{
				return this.named_Professorship_TitleField;
			}
			set
			{
				this.named_Professorship_TitleField = value;
				this.RaisePropertyChanged("Named_Professorship_Title");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_UnitObjectType Academic_Unit_for_Named_Professorship_Reference
		{
			get
			{
				return this.academic_Unit_for_Named_Professorship_ReferenceField;
			}
			set
			{
				this.academic_Unit_for_Named_Professorship_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_for_Named_Professorship_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Term_Limits
		{
			get
			{
				return this.term_LimitsField;
			}
			set
			{
				this.term_LimitsField = value;
				this.RaisePropertyChanged("Term_Limits");
			}
		}

		[XmlIgnore]
		public bool Term_LimitsSpecified
		{
			get
			{
				return this.term_LimitsFieldSpecified;
			}
			set
			{
				this.term_LimitsFieldSpecified = value;
				this.RaisePropertyChanged("Term_LimitsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Appointment_Restrictions
		{
			get
			{
				return this.appointment_RestrictionsField;
			}
			set
			{
				this.appointment_RestrictionsField = value;
				this.RaisePropertyChanged("Appointment_Restrictions");
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
