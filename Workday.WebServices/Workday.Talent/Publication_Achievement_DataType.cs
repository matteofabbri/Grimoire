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
	public class Publication_Achievement_DataType : INotifyPropertyChanged
	{
		private string publication_Achievement_IDField;

		private bool remove_Publication_AchievementField;

		private bool remove_Publication_AchievementFieldSpecified;

		private Publication_TypeObjectType publication_Achievement_Type_ReferenceField;

		private string titleField;

		private DateTime publication_DateField;

		private bool publication_DateFieldSpecified;

		private string descriptionField;

		private string publicationField;

		private string publisherField;

		private decimal volumeField;

		private bool volumeFieldSpecified;

		private decimal issueField;

		private bool issueFieldSpecified;

		private string pageField;

		private string uRLField;

		private bool peer_ReviewedField;

		private bool peer_ReviewedFieldSpecified;

		private Publication_Contributor_DataType[] publication_ContributorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Publication_Achievement_ID
		{
			get
			{
				return this.publication_Achievement_IDField;
			}
			set
			{
				this.publication_Achievement_IDField = value;
				this.RaisePropertyChanged("Publication_Achievement_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Publication_Achievement
		{
			get
			{
				return this.remove_Publication_AchievementField;
			}
			set
			{
				this.remove_Publication_AchievementField = value;
				this.RaisePropertyChanged("Remove_Publication_Achievement");
			}
		}

		[XmlIgnore]
		public bool Remove_Publication_AchievementSpecified
		{
			get
			{
				return this.remove_Publication_AchievementFieldSpecified;
			}
			set
			{
				this.remove_Publication_AchievementFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Publication_AchievementSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Publication_TypeObjectType Publication_Achievement_Type_Reference
		{
			get
			{
				return this.publication_Achievement_Type_ReferenceField;
			}
			set
			{
				this.publication_Achievement_Type_ReferenceField = value;
				this.RaisePropertyChanged("Publication_Achievement_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Publication_Date
		{
			get
			{
				return this.publication_DateField;
			}
			set
			{
				this.publication_DateField = value;
				this.RaisePropertyChanged("Publication_Date");
			}
		}

		[XmlIgnore]
		public bool Publication_DateSpecified
		{
			get
			{
				return this.publication_DateFieldSpecified;
			}
			set
			{
				this.publication_DateFieldSpecified = value;
				this.RaisePropertyChanged("Publication_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public string Publication
		{
			get
			{
				return this.publicationField;
			}
			set
			{
				this.publicationField = value;
				this.RaisePropertyChanged("Publication");
			}
		}

		[XmlElement(Order = 7)]
		public string Publisher
		{
			get
			{
				return this.publisherField;
			}
			set
			{
				this.publisherField = value;
				this.RaisePropertyChanged("Publisher");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Volume
		{
			get
			{
				return this.volumeField;
			}
			set
			{
				this.volumeField = value;
				this.RaisePropertyChanged("Volume");
			}
		}

		[XmlIgnore]
		public bool VolumeSpecified
		{
			get
			{
				return this.volumeFieldSpecified;
			}
			set
			{
				this.volumeFieldSpecified = value;
				this.RaisePropertyChanged("VolumeSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Issue
		{
			get
			{
				return this.issueField;
			}
			set
			{
				this.issueField = value;
				this.RaisePropertyChanged("Issue");
			}
		}

		[XmlIgnore]
		public bool IssueSpecified
		{
			get
			{
				return this.issueFieldSpecified;
			}
			set
			{
				this.issueFieldSpecified = value;
				this.RaisePropertyChanged("IssueSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
				this.RaisePropertyChanged("Page");
			}
		}

		[XmlElement(Order = 11)]
		public string URL
		{
			get
			{
				return this.uRLField;
			}
			set
			{
				this.uRLField = value;
				this.RaisePropertyChanged("URL");
			}
		}

		[XmlElement(Order = 12)]
		public bool Peer_Reviewed
		{
			get
			{
				return this.peer_ReviewedField;
			}
			set
			{
				this.peer_ReviewedField = value;
				this.RaisePropertyChanged("Peer_Reviewed");
			}
		}

		[XmlIgnore]
		public bool Peer_ReviewedSpecified
		{
			get
			{
				return this.peer_ReviewedFieldSpecified;
			}
			set
			{
				this.peer_ReviewedFieldSpecified = value;
				this.RaisePropertyChanged("Peer_ReviewedSpecified");
			}
		}

		[XmlElement("Publication_Contributor", Order = 13)]
		public Publication_Contributor_DataType[] Publication_Contributor
		{
			get
			{
				return this.publication_ContributorField;
			}
			set
			{
				this.publication_ContributorField = value;
				this.RaisePropertyChanged("Publication_Contributor");
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
