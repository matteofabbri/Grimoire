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
	public class Put_Proficiency_Rating_Scale_RequestType : INotifyPropertyChanged
	{
		private Proficiency_Rating_ScaleObjectType proficiency_Rating_Scale_ReferenceField;

		private Proficiency_Rating_Scale_DataType proficiency_Rating_Scale_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Proficiency_Rating_ScaleObjectType Proficiency_Rating_Scale_Reference
		{
			get
			{
				return this.proficiency_Rating_Scale_ReferenceField;
			}
			set
			{
				this.proficiency_Rating_Scale_ReferenceField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Scale_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Proficiency_Rating_Scale_DataType Proficiency_Rating_Scale_Data
		{
			get
			{
				return this.proficiency_Rating_Scale_DataField;
			}
			set
			{
				this.proficiency_Rating_Scale_DataField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Scale_Data");
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
