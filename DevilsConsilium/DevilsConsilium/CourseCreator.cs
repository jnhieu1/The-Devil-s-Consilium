using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsConsilium
{
    class CourseCreator
    {

        Courses cis105 = new Courses
            (
            "CIS105",
            "Computer Applications and Information Technology",
            "Introduces business information systems from a business intelligence perspective and the uses of " +
            "application software with emphasis on database and spreadsheet packages for efficient and effective problem solving.",
            3,
            false, false, true, false, false, false, false, false, false, false
            );

        Courses cis235 = new Courses
            (
            "CIS235",
            "Introduction To Information Systems",
            "Survey course introducing the competitive and strategic uses of information systems, how information systems are transforming organizations and their management, and the issues, difficulties, and opportunities facing the technology professional and business manager today.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis340 = new Courses
            (
            "CIS340",
            "Business Information System Development I",
            "Systems Development Life Cycle (SDLC) tools, techniques, and methodologies used to plan and analyze the needs of modern business information system development.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis345 = new Courses
            (
            "CIS345",
            "Business Information System Development II",
            "Provides a clear understanding of the Systems Development Life Cycle (SDLC) tools, techniques, and methodologies used to design, implement, and support modern business information systems development.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis365 = new Courses
            (
            "CIS365",
            "Business Database Systems Development",
            "Focuses on business database and data warehousing systems, development and management. Topics include capturing business requirements using data modeling, SQL, data security, operational and analytical data stores and data integrity.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis401 = new Courses
            (
            "CIS401",
            "Managing Cyber Risks in Enterprise Business Processes",
            "Covers the activities, decisions, risks and controls associated with enterprise business processes. Specific focus on the activities in the sales-to-cash (revenue cycle) and purchase-to-pay (expenditure cycle) processes. Students understand how IT enables performing those processes more efficiently and effectively. In addition to identifying internal controls necessary for accurate, complete performance of processes, also covers the fundamentals of cybersecurity.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis425 = new Courses
            (
            "CIS425",
            "Web Technologies for the Enterprise",
            "Modern Web application technologies for the enterprise. Covers development of Web applications for handling business transactions and strategies including the use of cloud-based applications.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis430 = new Courses
            (
            "CIS430",
            "Mobile Platforms for Business",
            "Mobile application development for the enterprise to address mobile transactions and consumer engagement. Covers business frameworks, app development; and management of devices, applications and services in today's multi-platform environment.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses cis440 = new Courses
            (
            "CIS440",
            "Capstone in Information Systems",
            "Offers a capstone experience integrating concepts from the business as well as the technology curricula. Students analyze, propose and develop a full technology solution for a business enterprise.",
            3,
            true, false, false, false, false, false, false, false, false, false
            );

        Courses wpc101 = new Courses
            (
            "WPC101",
            "Student Success in Business",
            "Introduces students to resources that help them to succeed in the W. P. Carey School of Business.",
            1,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses mat210 = new Courses
            (
            "MAT210",
            "Brief Calculus",
            "Differential and integral calculus of elementary functions with applications.",
            3,
            false, true, false, false, false, false, false, false ,false, false
            );

        Courses mat211 = new Courses
            (
            "MAT211",
            "Mathematics for Business Analysis",
            "Topics in business analysis, including: Lagrange multipliers, linear programming, linear algebra, " +
            "intermediate probability, random variables, discrete distributions, and continuous distributions.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses eng101 = new Courses
            (
            "ENG101",
            "First-Year Composition",
            "Discovers, organizes and develops ideas in relation to the writer's purpose, subject and audience. " +
            "Emphasizes modes of written discourse and effective use of rhetorical principles.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses eng102 = new Courses
            (
            "ENG102",
            "First-Year Composition",
            "Critical reading and writing; emphasizes strategies of academic discourse. Research paper required.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses soc101 = new Courses
            (
            "SOC101",
            "Introductory Sociology",
            "Fundamentals of sociology, organization of human groups and society, processes of interaction, and social change.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses psy101 = new Courses
            (
            "PSY101",
            "Introduction to Psychology",
            "Major areas of theory and research in psychology. Requires participation in department-sponsored research " +
            "or an educationally equivalent alternative activity.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses ala100 = new Courses
            (
            "ALA100",
            "Introduction to Environmental Design",
            "Surveys environmental design: includes historic examples and the theoretical, social, technical, and environmental forces that shape them.",
            3,
            false, false, false, true, false, false, false, false, true, true
            );

        Courses ecn211 = new Courses
            (
            "ECN211",
            "Macroeconomic Principles",
            "Basic macroeconomic analysis. Economic institutions and factors determining income levels, price levels, and employment levels.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses ecn212 = new Courses
            (
            "ECN212",
            "MicroEconomic Principles",
            "Basic microeconomic analysis. Theory of exchange and production, including the theory of the firm.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses ecn221 = new Courses
            (
            "ECN221",
            "Business Statistics",
            "Methods of statistical description. Applies probability theory and statistical inference in business.",
            3,
            false, false, true, false, false, false, false, false, false, false
            );

        Courses com100 = new Courses
            (
            "COM100",
            "Introduction to Human Communication",
            "Topics-oriented introduction to basic theories, dimensions, and concepts of human communicative interaction and behavior.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses com225 = new Courses
            (
            "COM225",
            "Public Speaking",
            "Verbal and nonverbal communication in platform speaking. Discussion and practice in vocal and physical delivery and in purposeful " +
            "organization and development of public communication.",
            3,
            true, false, false, false, false, false, false, false, false, false
            );

        Courses com230 = new Courses
            (
            "COM230",
            "Small Group Communication",
            "Principles and processes of small group communication, attitudes, and skills for effective participation and leadership " +
            "in small groups, small group problem solving, and decision making.",
            3,
            false, false, false, false, true, false, false, false, false, false
            );

        Courses com259 = new Courses
            (
            "COM259",
            "Communication in Business and the Professions",
            "Interpersonal, group, and public communication in business and professional organizations.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses com207 = new Courses
            (
            "COM207",
            "Introduction to Communication Inquiry",
            "Bases of inquiry into human communication, including introduction to notions of theory, philosophy, problems, and approaches to the study of communication.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses acc231 = new Courses
            (
            "ACC231",
            "Uses of Accounting Information I",
            "Introduces the uses of accounting information focusing on the evolution of the business cycle and how accounting information is used for internal and external purposes.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses acc241 = new Courses
            (
            "ACC241",
            "Uses of Accounting Information II",
            "Introduces the uses of accounting information focusing on the evolution of the business cycle and how accounting information is used for internal and external purposes. ",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses abs130 = new Courses
            (
            "ABS130",
            "Introduction to Environmental Science",
            "Introduces the interconnected nature of Earth's hydrosphere, lithosphere (soils and rocks), atmosphere, and biosphere.",
            4,
            false, false, false, false, false, true, false, false, false, false
            );

        Courses abs260 = new Courses
            (
            "ABS260",
            "Fundamentals of Sustainable Horticulture",
            "Principles and practices of horticulture, emphasizing development, growth, and propagation of horticultural plants and environmental factors that affect these processes.",
            4,
            false, false, false, false, false, false, true, false, false, false
            );

        Courses afr202 = new Courses
            (
            "AFR202",
            "Immigration and Ethnic Relations in the U.S.",
            "The ethnic and social consequences of international migration with a focus on the United States. Examines the impact of immigration on both American society and immigrant ethnic minorities over time.",
            3,
            false, false, false, false, true, false, false, true, false, false
            );

        Courses afr210 = new Courses
           (
            "AFT210",
            "Introduction to African American Studies",
            "Examines the political, historical, and cultural origins of African American studies as an academic discipline.",
            3,
            false, false, false, false, false, false, false, true, false, false
           );

        Courses afr333 = new Courses
            (
            "AFR333",
            "American Ethnic Literature",
            "Examines America's multiethnic identity through works of literature that depict American ethnic, gender, and class sensibilities.",
            3,
            false, false, false, true, false, false, false, true, false, false
            );

        Courses scm300 = new Courses
            (
            "SCM300",
            "Global Supply Operations",
            "Explores modern global integrated supply chain management. Covers traditional supply chain topics such as procurement, inventory management, operations, quality management, logistics and transportation. Also discusses issues related to sustainability, humanitarian logistics, ethical business practices and supply chain analytics in the context of evolving supply chains around the world. Students discover how business processes, performance metrics and modern supply chain IT tools aid in the management and growth of effective and efficient supply chains.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses mkt300 = new Courses
            (
            "MKT300",
            "Marketing and Business Performance",
            "The dynamic role of marketing within society and organizations. Emphasizes frameworks and analytical tools that ensure customer focus and drive organizational performance.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses eng302 = new Courses
            (
            "ENG302",
            "Business Writing",
            "Advanced interdisciplinary writing course designed to improve the workplace writing competence of W. P. Carey School of Business professional and preprofessional students. Lecture, discussion, case studies, cooperative learning, interactive, Internet, student presentations. ",
            3,
            true, false, false, false, false, false, false, false, false, false
            );

        Courses agb302 = new Courses
            (
            "AGB302",
            "International Management and Agribusiness",
            "Management and agribusiness issues in the transition of developing countries from subsistence to global operations and competition.",
            3,
            false, false, false, false, false, false, false ,false, true, false
            );

        Courses ecn306 = new Courses
            (
            "ECN306",
            "Survey of International Economics",
            "Surveys international trade issues, commercial policy, trade theory, customs unions, and international monetary topics.",
            3,
            false, false, false, false, true, false, false, false, true, false
            );

        Courses mgt302 = new Courses
            (
            "MGT302",
            "Principles of International Business",
            "Multidisciplinary analysis of international economic and financial environment. Operations of multinational firms and their interaction with home and host societies.",
            3,
            false, false, false, false, false, false, false, false, true, false
            );

        Courses mkt425 = new Courses
            (
            "MKT425",
            "Global Marketing Management",
            "Analyzes marketing strategies and practices developed by firms to compete in global markets and adapt to changing international environments.",
            3,
            false, false, false, false, false, false, false, false, true, false
            );

        Courses scm463 = new Courses
            (
            "SCM463",
            "Global Supply Chain Management",
            "With increased globalization and offshore sourcing, global supply chain management is becoming an important issue for many businesses. Like traditional supply chain management, the underlying factors behind the trend are reducing the costs of procurement and decreasing the risks related to purchasing activities. The big difference is that global supply chain management involves a company's worldwide interests and suppliers rather than simply a local or national orientation. Enables students to appreciate the challenges of operating supply chains across international boundaries including how to manage various salient issues including sociocultural, economic, technological and political factors that may shape decisions relating to sourcing and moving goods and services across different geographical boundaries.",
            3,
            false, false, false, false, false, false, false, false, true, false
            );

        Courses fin300 = new Courses
            (
            "FIN300",
            "Fundamentals of Finance",
            "Theory and problems in financial management of business enterprises.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses mgt300 = new Courses
            (
            "MGT300",
            "Organization and Management Leadership",
            "Analyzes strategic, behavioral, and human resource management perspectives, including principles of strategic management and leadership of human resources.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses les305 = new Courses
            (
            "LES305",
            "Business Law and Ethics for Managers",
            "Legal theories, ethical issues, and regulatory climate affecting business policies and decisions.",
            3,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses wpc480 = new Courses
            (
            "WPC480",
            "W.P. Carey Capstone Course",
            "Develops a general manager's or business owner's perspective on how organizations can create value. Creating long-run value by repeatedly producing goods and services that customers will buy at prices that cover the costs of producing them is the key to success for business organizations. Analyzing current and future environments to understand threats and opportunities in various institutional settings around the world is the starting point for thinking about how an organization might create value and gain sustainable competitive advantage. Evaluates the impact of institutional settings in different countries and ethical values on decision making. Students learn how to successfully manage relations with key stakeholders including customers, employees, suppliers of capital as well as other component goods and services, and stakeholders from various levels of government in different countries.",
            3,
            true, false, false, false, false, false, false, false, false, false
            );

        Courses wpc148 = new Courses
            (
            "WPC148",
            "Freshman Career Preparation",
            "Building career skills, interests and strengths as a college student.",
            0.25,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses wpc248 = new Courses
            (
            "WPC248",
            "Sophomore Career Preparation",
            "Research methods and strategic thinking for finding internships.",
            0.25,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses wpc348 = new Courses
            (
            "WPC348",
            "Junior Career Preparation",
            "Career relationship-building techniques and full-time, job-readiness skills.",
            0.25,
            false, false, false, false, false, false, false, false, false, false
            );

        Courses wpc448 = new Courses
            (
            "WPC448",
            "Intensive Career Preparation",
            "Intensive application of the job search cycle and processes for students still seeking post-graduation employment.",
            0.25,
            false, false, false, false, false, false, false, false, false, false
            );

    }
}
