using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Package_Reference_DataType : INotifyPropertyChanged
	{
		private Background_Check_PackageObjectType package_ReferenceField;

		private Background_Check_StatusObjectType status_ReferenceField;

		private string results_URLField;

		private string package_CommentField;

		private string package_NameField;

		private string package_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Check_PackageObjectType Package_Reference
		{
			get
			{
				return this.package_ReferenceField;
			}
			set
			{
				this.package_ReferenceField = value;
				this.RaisePropertyChanged("Package_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Background_Check_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Results_URL
		{
			get
			{
				return this.results_URLField;
			}
			set
			{
				this.results_URLField = value;
				this.RaisePropertyChanged("Results_URL");
			}
		}

		[XmlElement(Order = 3)]
		public string Package_Comment
		{
			get
			{
				return this.package_CommentField;
			}
			set
			{
				this.package_CommentField = value;
				this.RaisePropertyChanged("Package_Comment");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Package_Name
		{
			get
			{
				return this.package_NameField;
			}
			set
			{
				this.package_NameField = value;
				this.RaisePropertyChanged("Package_Name");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Package_Description
		{
			get
			{
				return this.package_DescriptionField;
			}
			set
			{
				this.package_DescriptionField = value;
				this.RaisePropertyChanged("Package_Description");
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
