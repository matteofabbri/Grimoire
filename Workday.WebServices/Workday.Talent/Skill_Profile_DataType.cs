using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Skill_Profile_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string skill_Profile_NameField;

		private string skill_Profile_DescriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Skill_Profile_CategoryObjectType[] skill_Profile_Category_ReferenceField;

		private Skill_Profile_Skill_DataType[] skill_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Skill_Profile_Name
		{
			get
			{
				return this.skill_Profile_NameField;
			}
			set
			{
				this.skill_Profile_NameField = value;
				this.RaisePropertyChanged("Skill_Profile_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Skill_Profile_Description
		{
			get
			{
				return this.skill_Profile_DescriptionField;
			}
			set
			{
				this.skill_Profile_DescriptionField = value;
				this.RaisePropertyChanged("Skill_Profile_Description");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Skill_Profile_Category_Reference", Order = 4)]
		public Skill_Profile_CategoryObjectType[] Skill_Profile_Category_Reference
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

		[XmlElement("Skill_Data", Order = 5)]
		public Skill_Profile_Skill_DataType[] Skill_Data
		{
			get
			{
				return this.skill_DataField;
			}
			set
			{
				this.skill_DataField = value;
				this.RaisePropertyChanged("Skill_Data");
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
