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
	public class Engagement_Action_Item_AssignmentType : INotifyPropertyChanged
	{
		private Student_Application_Action_Item_AssignmentObjectType engagement_Action_Item_Assignment_ReferenceField;

		private Engagement_Action_Item_Assignment_DataType[] engagement_Action_Item_Assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Application_Action_Item_AssignmentObjectType Engagement_Action_Item_Assignment_Reference
		{
			get
			{
				return this.engagement_Action_Item_Assignment_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Assignment_Reference");
			}
		}

		[XmlElement("Engagement_Action_Item_Assignment_Data", Order = 1)]
		public Engagement_Action_Item_Assignment_DataType[] Engagement_Action_Item_Assignment_Data
		{
			get
			{
				return this.engagement_Action_Item_Assignment_DataField;
			}
			set
			{
				this.engagement_Action_Item_Assignment_DataField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Assignment_Data");
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
