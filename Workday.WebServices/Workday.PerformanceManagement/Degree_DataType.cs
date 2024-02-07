using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Degree_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private decimal rating_ValueField;

		private bool rating_ValueFieldSpecified;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private CountryObjectType[] restricted_to_Countries_ReferenceField;

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
		public decimal Rating_Value
		{
			get
			{
				return this.rating_ValueField;
			}
			set
			{
				this.rating_ValueField = value;
				this.RaisePropertyChanged("Rating_Value");
			}
		}

		[XmlIgnore]
		public bool Rating_ValueSpecified
		{
			get
			{
				return this.rating_ValueFieldSpecified;
			}
			set
			{
				this.rating_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Rating_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Restricted_to_Countries_Reference", Order = 5)]
		public CountryObjectType[] Restricted_to_Countries_Reference
		{
			get
			{
				return this.restricted_to_Countries_ReferenceField;
			}
			set
			{
				this.restricted_to_Countries_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Countries_Reference");
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
