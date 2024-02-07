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
	public class Communication_Method_Usage_DataType : INotifyPropertyChanged
	{
		private Communication_Usage_Type_ReferenceType[] type_ReferenceField;

		private string[] use_For_ReferenceField;

		private string commentsField;

		private bool publicField;

		private bool publicFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Type_Reference", Order = 0)]
		public Communication_Usage_Type_ReferenceType[] Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement("Use_For_Reference", Order = 1)]
		public string[] Use_For_Reference
		{
			get
			{
				return this.use_For_ReferenceField;
			}
			set
			{
				this.use_For_ReferenceField = value;
				this.RaisePropertyChanged("Use_For_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Public
		{
			get
			{
				return this.publicField;
			}
			set
			{
				this.publicField = value;
				this.RaisePropertyChanged("Public");
			}
		}

		[XmlIgnore]
		public bool PublicSpecified
		{
			get
			{
				return this.publicFieldSpecified;
			}
			set
			{
				this.publicFieldSpecified = value;
				this.RaisePropertyChanged("PublicSpecified");
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
