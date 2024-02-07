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
	public class Put_Close_Mentorship_Reason_RequestType : INotifyPropertyChanged
	{
		private bool deleteField;

		private bool deleteFieldSpecified;

		private Close_Mentorship_ReasonObjectType close_Mentorship_Reason_ReferenceField;

		private Close_Mentorship_Reason_DataType close_Mentorship_Reason_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Close_Mentorship_ReasonObjectType Close_Mentorship_Reason_Reference
		{
			get
			{
				return this.close_Mentorship_Reason_ReferenceField;
			}
			set
			{
				this.close_Mentorship_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Close_Mentorship_Reason_DataType Close_Mentorship_Reason_Data
		{
			get
			{
				return this.close_Mentorship_Reason_DataField;
			}
			set
			{
				this.close_Mentorship_Reason_DataField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Data");
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
