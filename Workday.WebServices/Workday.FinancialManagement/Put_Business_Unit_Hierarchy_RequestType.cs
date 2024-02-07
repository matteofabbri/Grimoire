using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Business_Unit_Hierarchy_RequestType : INotifyPropertyChanged
	{
		private Business_Unit_HierarchyObjectType business_Unit_Hierarchy_ReferenceField;

		private Business_Unit_Hierarchy_DataType[] business_Unit_Hierarchy_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Unit_HierarchyObjectType Business_Unit_Hierarchy_Reference
		{
			get
			{
				return this.business_Unit_Hierarchy_ReferenceField;
			}
			set
			{
				this.business_Unit_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_Reference");
			}
		}

		[XmlElement("Business_Unit_Hierarchy_Data", Order = 1)]
		public Business_Unit_Hierarchy_DataType[] Business_Unit_Hierarchy_Data
		{
			get
			{
				return this.business_Unit_Hierarchy_DataField;
			}
			set
			{
				this.business_Unit_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_Data");
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
