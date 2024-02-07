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
	public class Engagement_Action_Item_Assignment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Application_Action_Item_AssignmentObjectType[] engagement_Action_Item_Assignment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Engagement_Action_Item_Assignment_Reference", Order = 0)]
		public Student_Application_Action_Item_AssignmentObjectType[] Engagement_Action_Item_Assignment_Reference
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
