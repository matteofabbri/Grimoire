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
	public class Put_Skill_Profile_RequestType : INotifyPropertyChanged
	{
		private Skill_ProfileObjectType skill_Profile_ReferenceField;

		private Skill_Profile_DataType skill_Profile_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_ProfileObjectType Skill_Profile_Reference
		{
			get
			{
				return this.skill_Profile_ReferenceField;
			}
			set
			{
				this.skill_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Skill_Profile_DataType Skill_Profile_Data
		{
			get
			{
				return this.skill_Profile_DataField;
			}
			set
			{
				this.skill_Profile_DataField = value;
				this.RaisePropertyChanged("Skill_Profile_Data");
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
