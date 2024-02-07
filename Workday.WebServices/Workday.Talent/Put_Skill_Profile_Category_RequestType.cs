using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Skill_Profile_Category_RequestType : INotifyPropertyChanged
	{
		private Skill_Profile_CategoryObjectType skill_Profile_Category_ReferenceField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Skill_Profile_Category_DataType skill_Profile_Category_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_Profile_CategoryObjectType Skill_Profile_Category_Reference
		{
			get
			{
				return this.skill_Profile_Category_ReferenceField;
			}
			set
			{
				this.skill_Profile_Category_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Profile_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Skill_Profile_Category_DataType Skill_Profile_Category_Data
		{
			get
			{
				return this.skill_Profile_Category_DataField;
			}
			set
			{
				this.skill_Profile_Category_DataField = value;
				this.RaisePropertyChanged("Skill_Profile_Category_Data");
			}
		}

		[XmlElement(Order = 3)]
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
