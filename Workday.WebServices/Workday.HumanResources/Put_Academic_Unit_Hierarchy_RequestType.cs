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
	public class Put_Academic_Unit_Hierarchy_RequestType : INotifyPropertyChanged
	{
		private Academic_Unit_HierarchyObjectType academic_Unit_Hierarchy_ReferenceField;

		private Academic_Unit_Hierarchy_DataType academic_Unit_Hierarchy_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Unit_HierarchyObjectType Academic_Unit_Hierarchy_Reference
		{
			get
			{
				return this.academic_Unit_Hierarchy_ReferenceField;
			}
			set
			{
				this.academic_Unit_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Unit_Hierarchy_DataType Academic_Unit_Hierarchy_Data
		{
			get
			{
				return this.academic_Unit_Hierarchy_DataField;
			}
			set
			{
				this.academic_Unit_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Hierarchy_Data");
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
