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
	public class Add_Academic_Appointment_DataType : INotifyPropertyChanged
	{
		private General_Event_SubcategoryObjectType reason_ReferenceField;

		private object itemField;

		private Academic_Appointment_Snapshot_DataType academic_Appointment_DataField;

		private Create_Workday_Account_Sub_Business_ProcessType create_Workday_Account_Sub_Business_Process_for_Academic_AffiliateField;

		private Manage_Professional_Affiliation_Sub_Business_Process_DataType[] manage_Professional_Affiliation_Sub_Business_Process_for_Academic_AffiliateField;

		private Manage_Education_Sub_Business_Process_DataType[] manage_Education_Sub_Business_Process_for_Academic_AffiliateField;

		private Manage_Instructor_Eligibility_Sub_Business_Process_DataType[] manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_AffiliateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public General_Event_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement("Academic_Appointee_Reference", typeof(Academic_Appointee_EnabledObjectType), Order = 1), XmlElement("Create_Academic_Affiliate_Data", typeof(Create_Academic_Affiliate_DataType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2)]
		public Academic_Appointment_Snapshot_DataType Academic_Appointment_Data
		{
			get
			{
				return this.academic_Appointment_DataField;
			}
			set
			{
				this.academic_Appointment_DataField = value;
				this.RaisePropertyChanged("Academic_Appointment_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Create_Workday_Account_Sub_Business_ProcessType Create_Workday_Account_Sub_Business_Process_for_Academic_Affiliate
		{
			get
			{
				return this.create_Workday_Account_Sub_Business_Process_for_Academic_AffiliateField;
			}
			set
			{
				this.create_Workday_Account_Sub_Business_Process_for_Academic_AffiliateField = value;
				this.RaisePropertyChanged("Create_Workday_Account_Sub_Business_Process_for_Academic_Affiliate");
			}
		}

		[XmlElement("Manage_Professional_Affiliation_Sub_Business_Process_for_Academic_Affiliate", Order = 4)]
		public Manage_Professional_Affiliation_Sub_Business_Process_DataType[] Manage_Professional_Affiliation_Sub_Business_Process_for_Academic_Affiliate
		{
			get
			{
				return this.manage_Professional_Affiliation_Sub_Business_Process_for_Academic_AffiliateField;
			}
			set
			{
				this.manage_Professional_Affiliation_Sub_Business_Process_for_Academic_AffiliateField = value;
				this.RaisePropertyChanged("Manage_Professional_Affiliation_Sub_Business_Process_for_Academic_Affiliate");
			}
		}

		[XmlElement("Manage_Education_Sub_Business_Process_for_Academic_Affiliate", Order = 5)]
		public Manage_Education_Sub_Business_Process_DataType[] Manage_Education_Sub_Business_Process_for_Academic_Affiliate
		{
			get
			{
				return this.manage_Education_Sub_Business_Process_for_Academic_AffiliateField;
			}
			set
			{
				this.manage_Education_Sub_Business_Process_for_Academic_AffiliateField = value;
				this.RaisePropertyChanged("Manage_Education_Sub_Business_Process_for_Academic_Affiliate");
			}
		}

		[XmlElement("Manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_Affiliate", Order = 6)]
		public Manage_Instructor_Eligibility_Sub_Business_Process_DataType[] Manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_Affiliate
		{
			get
			{
				return this.manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_AffiliateField;
			}
			set
			{
				this.manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_AffiliateField = value;
				this.RaisePropertyChanged("Manage_Instructor_Eligibility_Sub_Business_Process_for_Academic_Affiliate");
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
