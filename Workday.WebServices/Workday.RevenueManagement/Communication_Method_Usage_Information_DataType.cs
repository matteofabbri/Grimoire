using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Communication_Method_Usage_Information_DataType : INotifyPropertyChanged
	{
		private Communication_Usage_Type_DataType[] type_DataField;

		private Communication_Usage_BehaviorObjectType[] use_For_ReferenceField;

		private Communication_Usage_Behavior_TenantedObjectType[] use_For_Tenanted_ReferenceField;

		private string commentsField;

		private bool publicField;

		private bool publicFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Type_Data", Order = 0)]
		public Communication_Usage_Type_DataType[] Type_Data
		{
			get
			{
				return this.type_DataField;
			}
			set
			{
				this.type_DataField = value;
				this.RaisePropertyChanged("Type_Data");
			}
		}

		[XmlElement("Use_For_Reference", Order = 1)]
		public Communication_Usage_BehaviorObjectType[] Use_For_Reference
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

		[XmlElement("Use_For_Tenanted_Reference", Order = 2)]
		public Communication_Usage_Behavior_TenantedObjectType[] Use_For_Tenanted_Reference
		{
			get
			{
				return this.use_For_Tenanted_ReferenceField;
			}
			set
			{
				this.use_For_Tenanted_ReferenceField = value;
				this.RaisePropertyChanged("Use_For_Tenanted_Reference");
			}
		}

		[XmlElement(Order = 3)]
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
