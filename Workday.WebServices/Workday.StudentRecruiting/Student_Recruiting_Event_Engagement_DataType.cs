using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Event_Engagement_DataType : INotifyPropertyChanged
	{
		private Engagement_Communication_Usage_Type_Order_DataType[] send_To_Email_Priority_DataField;

		private Student_Engagement_ItemObjectType invite_Item_ReferenceField;

		private DateTime invite_Start_DateField;

		private bool invite_Start_DateFieldSpecified;

		private DateTime invite_Stop_DateField;

		private bool invite_Stop_DateFieldSpecified;

		private Student_Recruiting_Event_Engagement_Follow_Up_DataType[] student_Recruiting_Event_Engagement_Follow_Up_DataField;

		private Student_Engagement_ItemObjectType registration_Confirmation_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Send_To_Email_Priority_Data", Order = 0)]
		public Engagement_Communication_Usage_Type_Order_DataType[] Send_To_Email_Priority_Data
		{
			get
			{
				return this.send_To_Email_Priority_DataField;
			}
			set
			{
				this.send_To_Email_Priority_DataField = value;
				this.RaisePropertyChanged("Send_To_Email_Priority_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Engagement_ItemObjectType Invite_Item_Reference
		{
			get
			{
				return this.invite_Item_ReferenceField;
			}
			set
			{
				this.invite_Item_ReferenceField = value;
				this.RaisePropertyChanged("Invite_Item_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Invite_Start_Date
		{
			get
			{
				return this.invite_Start_DateField;
			}
			set
			{
				this.invite_Start_DateField = value;
				this.RaisePropertyChanged("Invite_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Invite_Start_DateSpecified
		{
			get
			{
				return this.invite_Start_DateFieldSpecified;
			}
			set
			{
				this.invite_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invite_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Invite_Stop_Date
		{
			get
			{
				return this.invite_Stop_DateField;
			}
			set
			{
				this.invite_Stop_DateField = value;
				this.RaisePropertyChanged("Invite_Stop_Date");
			}
		}

		[XmlIgnore]
		public bool Invite_Stop_DateSpecified
		{
			get
			{
				return this.invite_Stop_DateFieldSpecified;
			}
			set
			{
				this.invite_Stop_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invite_Stop_DateSpecified");
			}
		}

		[XmlElement("Student_Recruiting_Event_Engagement_Follow_Up_Data", Order = 4)]
		public Student_Recruiting_Event_Engagement_Follow_Up_DataType[] Student_Recruiting_Event_Engagement_Follow_Up_Data
		{
			get
			{
				return this.student_Recruiting_Event_Engagement_Follow_Up_DataField;
			}
			set
			{
				this.student_Recruiting_Event_Engagement_Follow_Up_DataField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Engagement_Follow_Up_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Student_Engagement_ItemObjectType Registration_Confirmation_Item_Reference
		{
			get
			{
				return this.registration_Confirmation_Item_ReferenceField;
			}
			set
			{
				this.registration_Confirmation_Item_ReferenceField = value;
				this.RaisePropertyChanged("Registration_Confirmation_Item_Reference");
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
