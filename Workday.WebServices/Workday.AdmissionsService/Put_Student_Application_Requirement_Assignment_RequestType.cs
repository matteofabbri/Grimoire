using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Student_Application_Requirement_Assignment_RequestType : INotifyPropertyChanged
	{
		private Student_Application_Action_Item_AssignmentObjectType engagement_Action_Item_Assignment_ReferenceField;

		private Engagement_Action_Item_Assignment_DataType engagement_Action_Item_Assignment_DataField;

		private string versionField;

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

		[XmlElement(Order = 1)]
		public Engagement_Action_Item_Assignment_DataType Engagement_Action_Item_Assignment_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
