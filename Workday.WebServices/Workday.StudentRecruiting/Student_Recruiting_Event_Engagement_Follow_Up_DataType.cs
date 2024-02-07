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
	public class Student_Recruiting_Event_Engagement_Follow_Up_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType follow_Up_Item_Container_ReferenceField;

		private Event_Follow_Up_Send_ToObjectType send_To_ReferenceField;

		private Student_Engagement_ItemObjectType follow_Up_Item_ReferenceField;

		private decimal send_AfterField;

		private Date_IntervalObjectType date_Interval_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Follow_Up_Item_Container_Reference
		{
			get
			{
				return this.follow_Up_Item_Container_ReferenceField;
			}
			set
			{
				this.follow_Up_Item_Container_ReferenceField = value;
				this.RaisePropertyChanged("Follow_Up_Item_Container_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Follow_Up_Send_ToObjectType Send_To_Reference
		{
			get
			{
				return this.send_To_ReferenceField;
			}
			set
			{
				this.send_To_ReferenceField = value;
				this.RaisePropertyChanged("Send_To_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Engagement_ItemObjectType Follow_Up_Item_Reference
		{
			get
			{
				return this.follow_Up_Item_ReferenceField;
			}
			set
			{
				this.follow_Up_Item_ReferenceField = value;
				this.RaisePropertyChanged("Follow_Up_Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Send_After
		{
			get
			{
				return this.send_AfterField;
			}
			set
			{
				this.send_AfterField = value;
				this.RaisePropertyChanged("Send_After");
			}
		}

		[XmlElement(Order = 4)]
		public Date_IntervalObjectType Date_Interval_Reference
		{
			get
			{
				return this.date_Interval_ReferenceField;
			}
			set
			{
				this.date_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Date_Interval_Reference");
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
