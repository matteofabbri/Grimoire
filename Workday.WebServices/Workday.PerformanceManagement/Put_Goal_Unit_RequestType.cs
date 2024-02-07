using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Goal_Unit_RequestType : INotifyPropertyChanged
	{
		private Goal_Target_And_Actual_Track_By__Tenanted_ObjectType goal_Unit_ReferenceField;

		private Goal_Unit_DataType goal_Unit_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goal_Target_And_Actual_Track_By__Tenanted_ObjectType Goal_Unit_Reference
		{
			get
			{
				return this.goal_Unit_ReferenceField;
			}
			set
			{
				this.goal_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Goal_Unit_DataType Goal_Unit_Data
		{
			get
			{
				return this.goal_Unit_DataField;
			}
			set
			{
				this.goal_Unit_DataField = value;
				this.RaisePropertyChanged("Goal_Unit_Data");
			}
		}

		[XmlElement(Order = 2)]
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
