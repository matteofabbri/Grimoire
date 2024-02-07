using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_External_Item_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private External_URLType[] external_URL_DataField;

		private StudentObjectType[] recipients_ReferenceField;

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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("External_URL_Data", Order = 3)]
		public External_URLType[] External_URL_Data
		{
			get
			{
				return this.external_URL_DataField;
			}
			set
			{
				this.external_URL_DataField = value;
				this.RaisePropertyChanged("External_URL_Data");
			}
		}

		[XmlElement("Recipients_Reference", Order = 4)]
		public StudentObjectType[] Recipients_Reference
		{
			get
			{
				return this.recipients_ReferenceField;
			}
			set
			{
				this.recipients_ReferenceField = value;
				this.RaisePropertyChanged("Recipients_Reference");
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
