using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Practical_Learning_Specific_Data_DataType : INotifyPropertyChanged
	{
		private External_AssociationObjectType external_Association_ReferenceField;

		private string external_SponsorField;

		private string external_Sponsor_Contact_DetailsField;

		private Standard_Meeting_PatternObjectType meeting_Pattern_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_AssociationObjectType External_Association_Reference
		{
			get
			{
				return this.external_Association_ReferenceField;
			}
			set
			{
				this.external_Association_ReferenceField = value;
				this.RaisePropertyChanged("External_Association_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Sponsor
		{
			get
			{
				return this.external_SponsorField;
			}
			set
			{
				this.external_SponsorField = value;
				this.RaisePropertyChanged("External_Sponsor");
			}
		}

		[XmlElement(Order = 2)]
		public string External_Sponsor_Contact_Details
		{
			get
			{
				return this.external_Sponsor_Contact_DetailsField;
			}
			set
			{
				this.external_Sponsor_Contact_DetailsField = value;
				this.RaisePropertyChanged("External_Sponsor_Contact_Details");
			}
		}

		[XmlElement(Order = 3)]
		public Standard_Meeting_PatternObjectType Meeting_Pattern_Reference
		{
			get
			{
				return this.meeting_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Pattern_Reference");
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
