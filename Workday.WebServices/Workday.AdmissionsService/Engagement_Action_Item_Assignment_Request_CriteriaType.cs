using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Action_Item_Assignment_Request_CriteriaType : INotifyPropertyChanged
	{
		private Application_Action_ItemObjectType engagement_Action_Item_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private Engagement_Action_Item_AssignableObjectType engagement_Action_Item_Assignable_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Application_Action_ItemObjectType Engagement_Action_Item_Reference
		{
			get
			{
				return this.engagement_Action_Item_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Engagement_Action_Item_AssignableObjectType Engagement_Action_Item_Assignable_Reference
		{
			get
			{
				return this.engagement_Action_Item_Assignable_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_Assignable_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Assignable_Reference");
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
