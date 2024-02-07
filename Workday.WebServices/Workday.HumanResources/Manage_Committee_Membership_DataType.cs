using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Committee_Membership_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private DateTime effective_DateField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private CommitteeObjectType committee__ReferenceField;

		private Committee_Membership_TypeObjectType committee_Membership_Type_ReferenceField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Manage_Professional_Affiliation_Sub_Business_Process_DataType manage_Professional_Affiliation_Sub_Business_Process_for_External_Committee_MemberField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Committee_Member_Reference", typeof(Committee_Member_EnabledObjectType), Order = 0), XmlElement("Create_External_Committee_Member_Data", typeof(Create_External_Committee_Member_DataType), Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
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

		[XmlElement(Order = 3)]
		public CommitteeObjectType Committee__Reference
		{
			get
			{
				return this.committee__ReferenceField;
			}
			set
			{
				this.committee__ReferenceField = value;
				this.RaisePropertyChanged("Committee__Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Committee_Membership_TypeObjectType Committee_Membership_Type_Reference
		{
			get
			{
				return this.committee_Membership_Type_ReferenceField;
			}
			set
			{
				this.committee_Membership_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Membership_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Manage_Professional_Affiliation_Sub_Business_Process_DataType Manage_Professional_Affiliation_Sub_Business_Process_for_External_Committee_Member
		{
			get
			{
				return this.manage_Professional_Affiliation_Sub_Business_Process_for_External_Committee_MemberField;
			}
			set
			{
				this.manage_Professional_Affiliation_Sub_Business_Process_for_External_Committee_MemberField = value;
				this.RaisePropertyChanged("Manage_Professional_Affiliation_Sub_Business_Process_for_External_Committee_Member");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
