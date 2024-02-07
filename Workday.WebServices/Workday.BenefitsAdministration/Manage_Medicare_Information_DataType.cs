using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Medicare_Information_DataType : INotifyPropertyChanged
	{
		private RoleObjectType person_ReferenceField;

		private DateTime event_DateField;

		private string hICNField;

		private General_Event_SubcategoryObjectType reporting_Reason_ReferenceField;

		private Medicare_ReasonObjectType medicare_Reason_ReferenceField;

		private Medicare_Part_A_DataType medicare_Part_A_DataField;

		private Medicare_Part_B_DataType medicare_Part_B_DataField;

		private Medicare_Part_D_DataType medicare_Part_D_DataField;

		private ESRD_DataType eSRD_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Event_Date
		{
			get
			{
				return this.event_DateField;
			}
			set
			{
				this.event_DateField = value;
				this.RaisePropertyChanged("Event_Date");
			}
		}

		[XmlElement(Order = 2)]
		public string HICN
		{
			get
			{
				return this.hICNField;
			}
			set
			{
				this.hICNField = value;
				this.RaisePropertyChanged("HICN");
			}
		}

		[XmlElement(Order = 3)]
		public General_Event_SubcategoryObjectType Reporting_Reason_Reference
		{
			get
			{
				return this.reporting_Reason_ReferenceField;
			}
			set
			{
				this.reporting_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Reporting_Reason_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Medicare_ReasonObjectType Medicare_Reason_Reference
		{
			get
			{
				return this.medicare_Reason_ReferenceField;
			}
			set
			{
				this.medicare_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Medicare_Reason_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Medicare_Part_A_DataType Medicare_Part_A_Data
		{
			get
			{
				return this.medicare_Part_A_DataField;
			}
			set
			{
				this.medicare_Part_A_DataField = value;
				this.RaisePropertyChanged("Medicare_Part_A_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Medicare_Part_B_DataType Medicare_Part_B_Data
		{
			get
			{
				return this.medicare_Part_B_DataField;
			}
			set
			{
				this.medicare_Part_B_DataField = value;
				this.RaisePropertyChanged("Medicare_Part_B_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Medicare_Part_D_DataType Medicare_Part_D_Data
		{
			get
			{
				return this.medicare_Part_D_DataField;
			}
			set
			{
				this.medicare_Part_D_DataField = value;
				this.RaisePropertyChanged("Medicare_Part_D_Data");
			}
		}

		[XmlElement(Order = 8)]
		public ESRD_DataType ESRD_Data
		{
			get
			{
				return this.eSRD_DataField;
			}
			set
			{
				this.eSRD_DataField = value;
				this.RaisePropertyChanged("ESRD_Data");
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
