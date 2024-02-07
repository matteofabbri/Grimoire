using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Resource_Plan_Requirement_Parameter_DataType : INotifyPropertyChanged
	{
		private string resource_Plan_Line_Requirement_Parameter_IDField;

		private External_FieldObjectType requirement_Field_ReferenceField;

		private InstanceObjectType[] requirement_Value_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Plan_Line_Requirement_Parameter_ID
		{
			get
			{
				return this.resource_Plan_Line_Requirement_Parameter_IDField;
			}
			set
			{
				this.resource_Plan_Line_Requirement_Parameter_IDField = value;
				this.RaisePropertyChanged("Resource_Plan_Line_Requirement_Parameter_ID");
			}
		}

		[XmlElement(Order = 1)]
		public External_FieldObjectType Requirement_Field_Reference
		{
			get
			{
				return this.requirement_Field_ReferenceField;
			}
			set
			{
				this.requirement_Field_ReferenceField = value;
				this.RaisePropertyChanged("Requirement_Field_Reference");
			}
		}

		[XmlElement("Requirement_Value_Reference", Order = 2)]
		public InstanceObjectType[] Requirement_Value_Reference
		{
			get
			{
				return this.requirement_Value_ReferenceField;
			}
			set
			{
				this.requirement_Value_ReferenceField = value;
				this.RaisePropertyChanged("Requirement_Value_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
